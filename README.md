# E-Commerce-Project
It is an API project that includes certain steps that should be included in an e-commerce application at a simple level.
# Note
In the cart entity, there are multiple product types with different quantities added by more than one user. 
The total cart of each user or visitor is all the products added with their own id in the cart entity. 
If the user wishes, he can deactivate the products in his basket individually, but if he places an order, the existing products in his basket are deleted.
When a visitor adds a product to their basket for the first time, they make the request to add the product to the basket using the 'POST api/cart/id' endpoint, leaving the 'id' section blank.
In other words, the request is sent as 'POST api/cart'. As a result, a UserId with IsLoggedIn property set to false is assigned. 
In subsequent operations of adding products to the basket, the request is made by including the assigned id in the 'POST api/cart/id' with the specified id.
