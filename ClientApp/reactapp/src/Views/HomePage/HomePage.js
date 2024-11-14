// src/components/HomePage/HomePage.js
import React from 'react';
import './HomePage.css';
import { Link } from 'react-router-dom';

import forHimImage from '../../images/for-him.jpg';
import forHerImage from '../../images/for-her.jpg';
import accessoriesImage from '../../images/accessories.jpg';
import newDropImage from '../../images/new-drop.jpg';

import product1Image from '../../images/product1.jpg';
import product2Image from '../../images/product2.jpg';
import product3Image from '../../images/product3.jpg';
import product4Image from '../../images/product4.jpg';


import bannerImage from '../../images/Background.png';

function HomePage() {
    return (
        <div className="homepage">
            {/* Hero Section */}
            <section
                className="hero"
                style={{
                    backgroundImage: `url(${bannerImage})`,
                    backgroundSize: 'cover',
                    backgroundPosition: 'center',
                    height: '60vh', // Wysokość banera
                }}
            >
                <h1>Welcome to Pump Palace</h1>
                <p>Your one-stop shop for the latest trends!</p>
            </section>

            {/* Categories Section */}
            <section className="categories">
                <h2>Shop by Category</h2>
                <div className="category-list">
                    <Link to="/category/for-him" className="category" style={{ backgroundImage: `url(${forHimImage})` }}>
                        For Him
                    </Link>
                    <Link to="/category/for-her" className="category" style={{ backgroundImage: `url(${forHerImage})` }}>
                        For Her
                    </Link>
                    <Link to="/category/accessories" className="category" style={{ backgroundImage: `url(${accessoriesImage})` }}>
                        Accessories
                    </Link>
                    <Link to="/category/new-drop" className="category" style={{ backgroundImage: `url(${newDropImage})` }}>
                        New Drop
                    </Link>
                </div>
            </section>

            <section className="popular-products">
                <h2>Popular Products</h2>
                <div className="product-list">
                    <div className="product-card">
                        <img src={product1Image} alt="Product 1" className="product-image" />
                    </div>
                    <div className="product-card">
                        <img src={product2Image} alt="Product 2" className="product-image" />
                    </div>
                    <div className="product-card">
                        <img src={product3Image} alt="Product 3" className="product-image" />
                    </div>
                    <div className="product-card">
                        <img src={product4Image} alt="Product 4" className="product-image" />
                    </div>
                </div>
            </section>


            {/* Testimonials Section */}
            <section className="testimonials">
                <h2>What Our Customers Say</h2>
                <div className="testimonial-list">
                    <div className="testimonial">"Amazing products!" - Anna</div>
                    <div className="testimonial">"Great customer service!" - John</div>
                    <div className="testimonial">"Fast shipping and quality items." - Lisa</div>
                </div>
            </section>

            {/* Newsletter Section */}
            <section className="newsletter">
                <h2>Stay Updated</h2>
                <p>Subscribe to our newsletter for the latest news and exclusive offers.</p>
                <input type="email" placeholder="Enter your email" />
                <button className="subscribe-button">Subscribe</button>
            </section>
        </div>
    );
}

export default HomePage;
