// src/App.js
import React from 'react';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import HomePage from './Views/HomePage/HomePage';
import ProductList from './Views/Products/ProductList/ProductList';
import Cart from './Views/Products/Cart/Cart';
import LoginPage from './Views/Authentication/LoginPage/LoginPage';
import ForgotPasswordPage from './Views/Authentication/ForgotPasswordPage/ForgotPasswordPage';
import RegisterPage from './Views/Authentication/RegisterPage/RegisterPage';
import AdminPanel from './Views/Admin/AdminPanel/AdminPanel';
import Statistics from './Views/Admin/Statistics/Statistics';
import MyAccount from './Views/Customer/MyAccount/MyAccount';
import ForHimPage from './Views/Products/CategoryPages/ForHimPage';
import ForHerPage from './Views/Products/CategoryPages/ForHerPage';
import AccessoriesPage from './Views/Products/CategoryPages/AccessoriesPage';
import NewDropPage from './Views/Products/CategoryPages/NewDropPage';
import Header from './components/Header/Header';
import Footer from './components/Footer/Footer';
import './App.css';

function App() {
    return (
        <Router>
            <div className="App">
                <Header />
                <Routes>
                    <Route path="/" element={<HomePage />} />
                    <Route path="/products" element={<ProductList />} />
                    <Route path="/cart" element={<Cart />} />
                    <Route path="/login" element={<LoginPage />} />
                    <Route path="/forgot-password" element={<ForgotPasswordPage />} />
                    <Route path="/register" element={<RegisterPage />} />
                    <Route path="/admin-panel" element={<AdminPanel />} />
                    <Route path="/statistics" element={<Statistics />} />
                    <Route path="/my-account" element={<MyAccount />} />
                    <Route path="/category/for-him" element={<ForHimPage />} />
                    <Route path="/category/for-her" element={<ForHerPage />} />
                    <Route path="/category/accessories" element={<AccessoriesPage />} />
                    <Route path="/category/new-drop" element={<NewDropPage />} />
                    <Route path="/faq" element={<div>FAQ Content</div>} />
                    <Route path="/contact" element={<div>Contact Us Content</div>} />
                    <Route path="/about" element={<div>About Us Content</div>} />
                </Routes>
                <Footer /> {/* Stopka */}
            </div>
        </Router>
    );
}

export default App;
