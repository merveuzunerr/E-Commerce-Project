using AutoMapper;
using Core.DTOs;
using Core.Models;
using Core.Repositories;
using Core.Services;
using Core.UnitOfWorks;

namespace Service.Services
{
    public class CartService : Service<Cart>, ICartService
    {
        private readonly ICartRepository _cartRepository;
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;
        private readonly IUserAccountRepository _userAccountRepository;
        private readonly IUnitOfWork _unitOfWork;


        public CartService(IGenericRepository<Cart> repository, IUnitOfWork unitOfWork, ICartRepository cartRepository, IProductRepository productrepository, IMapper mapper, IUserAccountRepository userAccountRepository)
            : base(repository, unitOfWork)
        {
            _cartRepository=cartRepository;
            _mapper=mapper;
            _productRepository=productrepository;
            _unitOfWork = unitOfWork;
            _userAccountRepository=userAccountRepository;
        }

        public async Task<CustomResponseDto<CartWithUserIdDto>> AddCart(AddToCartDto cartDto, int? id)
        {

            var userId = id;

            if (userId == 0)
            {
                var guestUser = new UserAccount()
                {
                    IsGuest = true,
                    IsActive = true,
                    IsLoggedIn = false
                };

                var guestUserSaved = await _userAccountRepository.AddAsync(guestUser);
                await _unitOfWork.CommitAsync();

                userId = guestUserSaved.Id;
            }

            else
            {
                var user = _userAccountRepository.Where(x => x.Id == userId && x.IsActive==true).FirstOrDefault();
                if (user == null)
                {
                    return CustomResponseDto<CartWithUserIdDto>.Fail(404, "User is not found!");
                }

            }

            var product = _productRepository.Where(x => x.Id == cartDto.ProductId).FirstOrDefault();

            if (product == null)
            {
                return CustomResponseDto<CartWithUserIdDto>.Fail(404, "Product is not found!");
            }

            if (cartDto.Number > product.Stock)
            {
                return CustomResponseDto<CartWithUserIdDto>.Fail(404, "Not enough stock!");
            }

            var _cart = _cartRepository.Where(x => x.UserAccountId == userId && x.ProductId==product.Id).FirstOrDefault();

            if (_cart == null)
            {
                var cartDb = new Cart()
                {
                    Number = cartDto.Number,
                    ProductId = cartDto.ProductId,
                    UserAccountId = userId,
          
                };

                await _cartRepository.AddAsync(cartDb);
                await _unitOfWork.CommitAsync();

                var _cartDto= _mapper.Map<CartWithUserIdDto>(cartDb);
                return CustomResponseDto<CartWithUserIdDto>.Success(200, _cartDto);
            }
            else
            {

                _cart.Number = _cart.Number + cartDto.Number;
                if (_cart.Number > product.Stock)
                {
                    return CustomResponseDto<CartWithUserIdDto>.Fail(404, "Not enough stock!");
                }
                _cartRepository.Update(_cart);
                await _unitOfWork.CommitAsync();
                var _cartDto=_mapper.Map<CartWithUserIdDto>(_cart);
            
                return CustomResponseDto<CartWithUserIdDto>.Success(200, _cartDto);
            }

        }


        public async Task<CustomResponseDto<string>> RemoveCart(int userId, int productId)
        {
            var user = _cartRepository.Where(x => x.UserAccountId==userId).FirstOrDefault();
            var product = _cartRepository.Where(x => x.ProductId == productId).FirstOrDefault();

            if (user == null)
            {
                return CustomResponseDto<string>.Fail(404, "User is not found!");
            }

            if (product == null)
            {
                return CustomResponseDto<string>.Fail(404, "Product is not found!");
            }


            Cart cart = _cartRepository.Where(x => x.ProductId == productId && x.UserAccountId==userId).First();

            _cartRepository.Remove(cart);
            await _unitOfWork.CommitAsync();
            return CustomResponseDto<string>.Success(200, "The product is successfully remove from basket!");
        }

        public async Task<CustomResponseDto<List<CartDto>>> GetCart(int id)
        {
    
           var carts=  await _cartRepository.GetCartsAsync(id);
           var cartsDto=_mapper.Map<List<CartDto>>(carts.ToList());

            return CustomResponseDto<List<CartDto>>.Success(200, cartsDto);

        }

        public async Task<CustomResponseDto<AddToCartDto>> UpdateCart(AddToCartDto addToCart, int id)
        {
            var user = _cartRepository.Where(x => x.UserAccountId == id).FirstOrDefault();

            if (user == null)
            {
                return CustomResponseDto<AddToCartDto>.Fail(404, "User is not found!");
            }

            var product = _productRepository.Where(x => x.Id == addToCart.ProductId).FirstOrDefault();

            if (product == null)
            {
                return CustomResponseDto<AddToCartDto>.Fail(404, "Product is not found!");
            }

            if (addToCart.Number > product.Stock)
            {
                return CustomResponseDto<AddToCartDto>.Fail(404, "Not enough stock!");
            }

            if (addToCart.Number < 1)
            {
                return CustomResponseDto<AddToCartDto>.Fail(404, "Number must be more than 1");
            }

            var cart = _cartRepository.Where(x => x.ProductId == product.Id && x.UserAccountId==id).FirstOrDefault();
            if (cart != null)
            {
                cart.Number=addToCart.Number;
                _cartRepository.Update(cart);
                await _unitOfWork.CommitAsync();
                return CustomResponseDto<AddToCartDto>.Success(200, addToCart);
            }

            return CustomResponseDto<AddToCartDto>.Fail(200, "Product is not in your basket");
        }

        public async Task<CustomResponseDto<string>> Order(int id)
        {

            var carts = await _cartRepository.GetCartsAsync(id);
            var user = _cartRepository.Where(x => x.UserAccountId == id).FirstOrDefault();
            if (carts == null)
            {
                return CustomResponseDto<string>.Success(200, "There is no product in your cart!");
            }
            if(user==null)
            {
                return CustomResponseDto<string>.Success(200, "User is not found!");
            }
            _cartRepository.RemoveRange(carts);
            await _unitOfWork.CommitAsync();
            return CustomResponseDto<string>.Success(200, "Order was booked succesfully");

        }


    }
}



