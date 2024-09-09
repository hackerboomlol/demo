const cart = [];
const addToCartButtons = document.querySelectorAll('.add-to-cart');

addToCartButtons.forEach(button => {
    button.addEventListener('click', function() {
        const productElement = this.closest('.product-item');
        const productName = productElement.querySelector('h2').textContent;
        const productPrice = parseInt(productElement.querySelector('p').textContent.match(/\d+/g)[0]);
        const quantity = parseInt(productElement.querySelector('.quantity-input').value);
        
        // Add product to cart
        cart.push({ productName, productPrice, quantity });
        
        // Update cart total
        const totalAmount = cart.reduce((total, item) => total + (item.productPrice * item.quantity), 0);
        console.log(`Cart total: ₹${totalAmount}`);
    });
});
