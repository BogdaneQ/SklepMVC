import React from 'react';
import { useNavigate } from 'react-router-dom'; 
import './AdminPanel.css';

function AdminPanel() {
    const navigate = useNavigate(); // Hook do nawigacji

    return (
        <div className="admin-panel">
            <h1>Admin Panel</h1>
            <p>Manage the site content, user accounts, and site settings from this panel.</p>
            <div className="admin-actions">
                {/* Po kliknięciu przenosi do widoku ManageProducts */}
                <button onClick={() => navigate('/manage-products')}>Manage Products</button>
                <button onClick={() => navigate('/view-orders')}>View Orders</button>
                <button onClick={() => navigate('/manage-users')}>Manage Users</button>
            </div>
        </div>
    );
}

export default AdminPanel;
