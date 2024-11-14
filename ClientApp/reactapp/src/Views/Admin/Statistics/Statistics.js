import React from 'react';
import './Statistics.css';

function Statistics() {
    return (
        <div className="statistics">
            <h1>Statistics</h1>
            <p>Here you can view various statistics about the site, including user activity, sales, and more.</p>
            <div className="stats-container">
                <div className="stat">
                    <h2>Total Sales</h2>
                    <p>$50,000</p>
                </div>
                <div className="stat">
                    <h2>New Users</h2>
                    <p>120</p>
                </div>
                <div className="stat">
                    <h2>Monthly Visits</h2>
                    <p>5,000</p>
                </div>
            </div>
        </div>
    );
}

export default Statistics;
