body {
    font-family: Arial, sans-serif;
    margin: 0;
    padding: 0;
    background-color: #f5f5f5;
}

.product-list {
    max-width: 1200px;
    margin: 0 auto;
    padding: 20px;
}

.product-item {
    display: flex;
    justify-content: space-between;
    background-color: white;
    border-radius: 8px;
    margin-bottom: 15px;
    padding: 10px;
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
}

.product-image {
    max-width: 100px;
    max-height: 100px;
}

.product-details {
    flex-grow: 1;
    padding-left: 15px;
}

.product-details h2 {
    font-size: 1.2em;
    margin: 0;
}

.discount {
    color: green;
    font-weight: bold;
}

.product-action {
    display: flex;
    align-items: center;
}

.quantity-input {
    width: 60px;
    margin-right: 10px;
    padding: 5px;
}

.add-to-cart {
    background-color: #28a745;
    color: white;
    border: none;
    padding: 10px 20px;
    border-radius: 5px;
    cursor: pointer;
}

.add-to-cart:hover {
    background-color: #218838;
}
