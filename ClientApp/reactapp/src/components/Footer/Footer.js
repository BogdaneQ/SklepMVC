// src/components/Footer/Footer.js
import React from 'react';
import { Link } from 'react-router-dom';
import './Footer.css';

function Footer() {
    return (
        <footer className="footer">
            <div className="footer-links">
                <Link to="/faq">FAQ</Link>
                <Link to="/contact">Contact Us</Link>
                <Link to="/about">About Us</Link>
            </div>
            <p className="footer-text">&copy; {new Date().getFullYear()} Pump Palace.</p>
        </footer>
    );
}

export default Footer;
