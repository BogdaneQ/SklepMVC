import React, { useState, useEffect } from 'react';
import './ManageProducts.css';

function ManageProducts() {
    const [products, setProducts] = useState([]); // Lista produktów
    const [newProduct, setNewProduct] = useState({
        id: null,
        name: '',
        description: '',
        price: 0,
        discountPrice: 0,
        vat: 23,
        currency: 'USD',
        stock: 0,
        thumbnailUrl: '',
        imageUrl: '',
        categoryId: 1,
        isHidden: false,
        isNew: false,
        isPromotion: false,
    });

    // Pobieranie produktów z API
    useEffect(() => {
        fetch('/api/products')
            .then(response => response.json())
            .then(data => setProducts(data))
            .catch(error => console.error('Error fetching products:', error));
    }, []);

    const handleInputChange = (e) => {
        const { name, value, type, checked } = e.target;
        setNewProduct({
            ...newProduct,
            [name]: type === 'checkbox' ? checked : value,
        });
    };

    const handleAddProduct = () => {
        console.log('Product data being sent:', newProduct); // Logowanie danych

        const method = newProduct.id ? 'PUT' : 'POST';
        const url = newProduct.id ? `/api/products/${newProduct.id}` : '/api/products';

        fetch(url, {
            method: method,
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify(newProduct),
        })
            .then(response => response.json())
            .then(data => {
                if (newProduct.id) {
                    setProducts(products.map(product => product.id === data.id ? data : product));
                } else {
                    setProducts([...products, data]);
                }
                setNewProduct({
                    id: null,
                    name: '',
                    description: '',
                    price: 0,
                    discountPrice: 0,
                    vat: 23,
                    currency: 'USD',
                    stock: 0,
                    thumbnailUrl: '',
                    imageUrl: '',
                    categoryId: 1,
                    isHidden: false,
                    isNew: false,
                    isPromotion: false,
                });
            })
            .catch(error => console.error('Error adding/updating product:', error));
    };


    const handleRemoveProduct = (id) => {
        fetch(`/api/products/${id}`, {
            method: 'DELETE',
        })
            .then(() => {
                setProducts(products.filter(product => product.id !== id));
            })
            .catch(error => console.error('Error removing product:', error));
    };

    const handleEditProduct = (id) => {
        const productToEdit = products.find((product) => product.id === id);
        if (productToEdit) {
            setNewProduct(productToEdit);
        }
    };

    return (
        <div className="manage-products">
            <h1>Manage Products</h1>

            <div className="product-form">
                <h2>{newProduct.id ? 'Edit Product' : 'Add Product'}</h2>

                <label htmlFor="name">Product Name</label>
                <input
                    id="name"
                    type="text"
                    name="name"
                    placeholder="Enter product name"
                    value={newProduct.name}
                    onChange={handleInputChange}
                />

                <label htmlFor="description">Product Description</label>
                <textarea
                    id="description"
                    name="description"
                    placeholder="Enter product description"
                    value={newProduct.description}
                    onChange={handleInputChange}
                />

                <label htmlFor="price">Price</label>
                <input
                    id="price"
                    type="number"
                    name="price"
                    placeholder="Enter product price"
                    value={newProduct.price}
                    onChange={handleInputChange}
                />

                <label htmlFor="discountPrice">Discount Price</label>
                <input
                    id="discountPrice"
                    type="number"
                    name="discountPrice"
                    placeholder="Enter discount price"
                    value={newProduct.discountPrice}
                    onChange={handleInputChange}
                />

                <label htmlFor="vat">VAT (%)</label>
                <input
                    id="vat"
                    type="number"
                    step="0.01"
                    name="vat"
                    placeholder="Enter VAT rate"
                    value={newProduct.vat}
                    onChange={handleInputChange}
                />

                <label htmlFor="currency">Currency</label>
                <input
                    id="currency"
                    type="text"
                    name="currency"
                    placeholder="Enter currency (e.g., USD)"
                    value={newProduct.currency}
                    onChange={handleInputChange}
                />

                <label htmlFor="stock">Stock</label>
                <input
                    id="stock"
                    type="number"
                    name="stock"
                    placeholder="Enter stock quantity"
                    value={newProduct.stock}
                    onChange={handleInputChange}
                />

                <label htmlFor="thumbnailUrl">Thumbnail URL</label>
                <input
                    id="thumbnailUrl"
                    type="text"
                    name="thumbnailUrl"
                    placeholder="Enter thumbnail URL"
                    value={newProduct.thumbnailUrl}
                    onChange={handleInputChange}
                />

                <label htmlFor="imageUrl">Image URL</label>
                <input
                    id="imageUrl"
                    type="text"
                    name="imageUrl"
                    placeholder="Enter image URL"
                    value={newProduct.imageUrl}
                    onChange={handleInputChange}
                />

                <label htmlFor="categoryId">Category ID</label>
                <input
                    id="categoryId"
                    type="number"
                    name="categoryId"
                    placeholder="Enter category ID"
                    value={newProduct.categoryId}
                    onChange={handleInputChange}
                />

                <label htmlFor="isHidden">Is Hidden</label>
                <input
                    id="isHidden"
                    type="checkbox"
                    name="isHidden"
                    checked={newProduct.isHidden}
                    onChange={handleInputChange}
                />

                <label htmlFor="isNew">Is New</label>
                <input
                    id="isNew"
                    type="checkbox"
                    name="isNew"
                    checked={newProduct.isNew}
                    onChange={handleInputChange}
                />

                <label htmlFor="isPromotion">Is Promotion</label>
                <input
                    id="isPromotion"
                    type="checkbox"
                    name="isPromotion"
                    checked={newProduct.isPromotion}
                    onChange={handleInputChange}
                />

                <button onClick={handleAddProduct}>
                    {newProduct.id ? 'Update Product' : 'Add Product'}
                </button>
            </div>

            <div className="product-list">
                <h2>Product List</h2>
                {products.length > 0 ? (
                    products.map((product) => (
                        <div key={product.id} className="product-item">
                            <h3>{product.name}</h3>
                            <p>{product.description}</p>
                            <p className="price">Price: {product.price} {product.currency}</p>
                            <p>Stock: {product.stock}</p>
                            <div className="actions">
                                <button className="edit" onClick={() => handleEditProduct(product.id)}>Edit</button>
                                <button className="remove" onClick={() => handleRemoveProduct(product.id)}>Remove</button>
                            </div>
                        </div>
                    ))
                ) : (
                    <p>No products available. Add a new product to start managing your inventory.</p>
                )}
            </div>
        </div>
    );
}

export default ManageProducts;
