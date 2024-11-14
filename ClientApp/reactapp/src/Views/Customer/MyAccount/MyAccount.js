import React from 'react';
import './MyAccount.css';

function MyAccount() {
    return (
        <div className="my-account">
            <h1>My Account</h1>
            <p>Welcome to your account dashboard. Here, you can view your details, update information, and manage preferences.</p>
            <button>Edit Profile</button>
            <button>View Order History</button>
            <button>Logout</button>
        </div>
    );
}

export default MyAccount;
