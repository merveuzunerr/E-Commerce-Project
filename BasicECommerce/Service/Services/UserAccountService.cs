using AutoMapper;
using Core.DTOs;
using Core.Models;
using Core.Repositories;
using Core.Services;
using Core.UnitOfWorks;

namespace Service.Services
{
    public class UserAccountService : Service<UserAccount>, IUserAccountService
    {

        private readonly IUserAccountRepository _userAccountRepository;
        private readonly ICartRepository _cartRepository;
        private readonly IMapper _mapper;
        
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICartService _cartService;

        public UserAccountService(IGenericRepository<UserAccount> repository, IUnitOfWork unitOfWork, IUserAccountRepository userAccountrepository, IMapper mapper, ICartService cartService, ICartRepository cartRepository)
            : base(repository, unitOfWork)
        {
            _userAccountRepository=userAccountrepository;
            _mapper=mapper;
            _unitOfWork=unitOfWork;
            _cartService=cartService;
            _cartRepository=cartRepository;
        }

        public async Task<CustomResponseDto<UserAccountDto>> AddUserAccount(UserAccountDto userDto, int id)
        {
           
            if ((userDto.Password).Length < 10)
            {
                return CustomResponseDto<UserAccountDto>.Fail(404, "Password must contain at least 10 characters!");
            }

            if ((userDto.Password).Any(char.IsDigit)==false)
            {
                return CustomResponseDto<UserAccountDto>.Fail(400, "Password must contain at least 1 digit!");
            }

            if ((userDto.Password).Any(char.IsUpper)==false)
            {
                return CustomResponseDto<UserAccountDto>.Fail(400, "Password must contains at least 1 capitalized letter!");
            }

            if (userDto.Password != userDto.ConfirmPassword)
            {
                return CustomResponseDto<UserAccountDto>.Fail(400, "Password and confirm password is not match!");
            }

            var user = (_mapper.Map<UserAccount>(userDto));
            await _userAccountRepository.AddAsync(user);
            await _unitOfWork.CommitAsync();


            if (id != 0)
            {
                var guestUser = _userAccountRepository.Where(x => x.Id ==id && x.IsGuest==true).First();
               
                if (guestUser == null)
                {
                    return CustomResponseDto<UserAccountDto>.Fail(404, "Wrong guest id!");
                }
                var carts = _cartRepository.Where(x => x.UserAccountId==id && x.IsActive==true).ToList();
                foreach (var cart in carts)
                {
                    var addToCartDto = new AddToCartDto()
                    {
                        ProductId = cart.ProductId,
                        Number= cart.Number,
                    };

                    await _cartService.AddCart(addToCartDto, user.Id);
                    await _cartService.RemoveAsync(cart);
                }
                _userAccountRepository.Remove(guestUser);
                await _unitOfWork.CommitAsync();
                return CustomResponseDto<UserAccountDto>.Success(200, userDto);
            } 
            return CustomResponseDto<UserAccountDto>.Success(200, userDto);   
        }

        public async Task<CustomResponseDto<string>> Login(LoginDto loginDto, int id)
        {
            var user = await _userAccountRepository.FindByEmail(loginDto.Email);
            if (id == 0)
            {
                if (user == null)
                {
                    return CustomResponseDto<string>.Fail(404, "User is not found!");
                }

                if (loginDto.Password != user.Password)
                {
                    return CustomResponseDto<string>.Fail(404, "Incorrect password!");
                }

                if(user.IsActive==false)
                {
                    return CustomResponseDto<string>.Fail(404, "User is not active!");
                }
                user.IsLoggedIn = true;
                _userAccountRepository.Update(user);
                await _unitOfWork.CommitAsync();

                return CustomResponseDto<string>.Success(200, $"Successfully logged in. Your user id is {user.Id}");
            }

            else
            {
                var guestUser = _userAccountRepository.Where(x => x.Id ==id && x.IsGuest==true).First();
                
                if (guestUser == null)
                {
                    return CustomResponseDto<string>.Fail(404, "Wrong guest id!");
                }

                var carts = _cartRepository.Where(x => x.UserAccountId==id && x.IsActive==true).ToList();
               
                foreach (var cart in carts)
                {
                    var addToCartDto = new AddToCartDto()
                    {
                        ProductId = cart.ProductId,
                        Number= cart.Number,
                    };

                    await _cartService.AddCart(addToCartDto, user.Id);
                    await _cartService.RemoveAsync(cart);
                }
                _userAccountRepository.Remove(guestUser);
                await _unitOfWork.CommitAsync();
                return CustomResponseDto<string>.Success(200, "The products in the carts successfully merged!");
            }


        }

        public async Task<CustomResponseDto<string>> LogOut(int id)
        {
             var user = _userAccountRepository.Where( x=> x.Id == id && x.IsGuest==false).FirstOrDefault();
            if (user == null)
            {
                return CustomResponseDto<string>.Fail(404, "User is not found");
            }

            user.IsLoggedIn= false;
            _userAccountRepository.Update(user);
            await  _unitOfWork.CommitAsync();
            return CustomResponseDto<string>.Success(200, "Successfully logged out.");

        }
    }
}
