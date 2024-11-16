import React, { useState, useEffect } from 'react';
import './ProductList.css';

function ProductList() {
    const [products, setProducts] = useState([]);
    const [isLoading, setIsLoading] = useState(true);
    const [error, setError] = useState(null);

    useEffect(() => {
        fetch('/api/products')
            .then(response => {
                if (!response.ok) {
                    throw new Error(`HTTP error! status: ${response.status}`);
                }
                return response.json();
            })
            .then(data => {
                setProducts(data);
                setIsLoading(false);
            })
            .catch(error => {
                console.error('Error fetching products:', error);
                setError(error.message);
                setIsLoading(false);
            });
    }, []);

    return (
        <div className="product-list">
            <h2 className="title">Our Products</h2>
            <p className="subtitle">Discover our latest range of high-quality products.</p>

            {isLoading ? (
                <div className="loading">Loading products...</div>
            ) : error ? (
                <div className="error">Error: {error}</div>
            ) : products.length > 0 ? (
                <div className="products-container">
                    {products.map(product => (
                        <div key={product.id} className="product-card">
                            <img
                                src={product.thumbnailUrl || 'https://via.placeholder.com/150'}
                                alt={product.name}
                                className="product-thumbnail"
                            />
                            <div className="product-details">
                                <h3 className="product-name">{product.name}</h3>
                                <p className="product-description">{product.description}</p>
                                <p className="product-price">
                                    {product.discountPrice > 0 ? (
                                        <>
                                            <span className="old-price">${product.price.toFixed(2)}</span>{' '}
                                            <span className="discount-price">${product.discountPrice.toFixed(2)}</span>
                                        </>
                                    ) : (
                                        `$${product.price.toFixed(2)}`
                                    )}
                                </p>
                            </div>
                        </div>
                    ))}
                </div>
            ) : (
                <p className="no-products">No products available at the moment. Check back soon!</p>
            )}
        </div>
    );
}

export default ProductList;
