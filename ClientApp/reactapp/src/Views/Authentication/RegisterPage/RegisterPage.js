// src/components/RegisterPage/RegisterPage.js
import React from 'react';
import './RegisterPage.css';
import { Link } from 'react-router-dom';

function RegisterPage() {
    return (
        <div className="register-page">
            <div className="register-container">
                <div className="register-form">
                    <h2>Register</h2>
                    <form>
                        <input type="text" placeholder="Username" required />
                        <input type="text" placeholder="Full Name" required />
                        <input type="email" placeholder="Email address" required />
                        <input type="password" placeholder="Password" required />
                        <input type="text" placeholder="Full Address" required />
                        <input type="tel" placeholder="Phone Number" required />
                        <label className="newsletter">
                            <input type="checkbox" />
                            Subscribe to newsletter
                        </label>
                        <button type="submit">REGISTER</button>
                    </form>
                    <p>
                        Already have an account? <Link to="/login">Log in here</Link>
                    </p>
                </div>
                <div className="register-image" />
            </div>
        </div>
    );
}

export default RegisterPage;
