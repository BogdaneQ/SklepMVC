// src/components/ProductList/ProductList.js
import React from 'react';
import './ProductList.css';

function ProductList() {
    return (
        <div className="product-list">
            <h2>Products</h2>
            <p>Browse our extensive range of products.</p>
            {/* Lista produktów może być tutaj wczytywana dynamicznie */}
        </div>
    );
}

export default ProductList;
