// src/components/LoginPage/LoginPage.js
import React from 'react';
import './LoginPage.css';
import { Link } from 'react-router-dom';

function LoginPage() {
    return (
        <div className="login-page">
            <div className="login-container">
                <div className="login-form">
                    <h2>Log in</h2>
                    <form>
                        <input type="email" placeholder="Email address" required />
                        <input type="password" placeholder="Password" required />
                        <button type="submit">LOGIN</button>
                    </form>
                    <p>
                        <Link to="/forgot-password">Forgot password?</Link>
                    </p>
                    <p>
                        Don't have an account? <Link to="/register">Register here</Link>
                    </p>
                </div>
                <div className="login-image" />
            </div>
        </div>
    );
}

export default LoginPage;
