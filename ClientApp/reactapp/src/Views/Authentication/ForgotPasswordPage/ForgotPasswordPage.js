// src/components/ForgotPasswordPage/ForgotPasswordPage.js
import React from 'react';
import { Link } from 'react-router-dom';
import './ForgotPasswordPage.css';

function ForgotPasswordPage() {
    return (
        <div className="forgot-password-page">
            <div className="forgot-password-container">
                <div className="forgot-password-form">
                    <h2>Forgot Password</h2>
                    <p>Enter your email to receive a password reset link.</p>
                    <form>
                        <input type="email" placeholder="Email address" required />
                        <button type="submit">Send Reset Link</button>
                    </form>
                    <p>
                        <Link to="/login">Back to Login</Link>
                    </p>
                </div>
                <div className="forgot-password-image" />
            </div>
        </div>
    );
}

export default ForgotPasswordPage;
