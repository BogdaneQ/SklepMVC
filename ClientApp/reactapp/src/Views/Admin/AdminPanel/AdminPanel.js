import React from 'react';
import './AdminPanel.css';

function AdminPanel() {
    return (
        <div className="admin-panel">
            <h1>Admin Panel</h1>
            <p>Manage the site content, user accounts, and site settings from this panel.</p>
            <div className="admin-actions">
                <button>Manage Products</button>
                <button>View Orders</button>
                <button>Manage Users</button>
            </div>
        </div>
    );
}

export default AdminPanel;
