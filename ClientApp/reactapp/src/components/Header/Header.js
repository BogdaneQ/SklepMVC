// src/components/Header/Header.js
import React, { useState } from 'react';
import { Link } from 'react-router-dom';
import './Header.css';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faCartShopping, faUser } from '@fortawesome/free-solid-svg-icons';

function Header() {
    const [dropdownVisible, setDropdownVisible] = useState(false);

    return (
        <header className="header">
            <div className="header-top">
            <p>Pump</p>
                <Link to="/">
                    <img
                        src="/AtlasLogo.png"
                        alt="Logo"
                        className="logo"
                    />
                </Link>
                <p>Palace</p>
            </div>
            <nav className="nav">
                <div className="nav-left">
                    <Link to="/">Home</Link>
                    <div
                        className="dropdown"
                        onMouseEnter={() => setDropdownVisible(true)}
                        onMouseLeave={() => setDropdownVisible(false)}
                    >
                        <Link to="/products" className="dropdown-toggle">
                            Products
                        </Link>
                        {dropdownVisible && (
                            <div className="dropdown-menu">
                                <Link to="/category/for-her">For Her</Link>
                                <Link to="/category/for-him">For Him</Link>
                                <Link to="/category/accessories">Accessories</Link>
                            </div>
                        )}
                    </div>
                    <Link to="/admin-panel">Admin Panel</Link>
                    <Link to="/statistics">Statistics</Link>
                </div>

                <div className="nav-right">
                    <Link to="/cart">
                        <FontAwesomeIcon icon={faCartShopping} size="lg" />
                    </Link>
                    <Link to="/my-account">
                        <FontAwesomeIcon icon={faUser} size="lg" /> {/* Ikona zamiast tekstu "My Account" */}
                    </Link>
                    <Link to="/login">Login</Link>
                    <Link to="/register">Register</Link>
                </div>
            </nav>
        </header>
    );
}

export default Header;
