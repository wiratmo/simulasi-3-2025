import React, { useEffect, useState } from 'react'
import { Link, useNavigate } from 'react-router-dom'
import api from '../../services/api';

export default function List() {
    const navigate = useNavigate();
    const [loading, setLoading] = useState(true);
    const [installment, setInstallment] = useState([]);

    const fetchData = async() => {
        try {
            const res = await api.get("/instalment_cars");

            setInstallment(res.data.cars);
            setLoading(false);
        } catch (error) {
            const data = error.response?.data;
            if(data?.errors) {
                const message = Object.values(data.errors).flat().join(" | ");
                setError(message);
            } else if(data?.message) {
                setError(data.message);
            } else if(error.message) {
                setError(error.message)
            } else {
                setError("Terjadi kesalahan");
            }
        }
    }

    useEffect(() => {
        fetchData();
    }, []);

    if(loading) {
        return (
            <div>Loading....</div>
        )
    }

    

    return (
        <>
            <nav className="navbar navbar-expand-md navbar-dark fixed-top bg-primary">
                <div className="container">
                    <a className="navbar-brand" href="#">Installment Cars</a>
                    <button className="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarsExampleDefault" aria-controls="navbarsExampleDefault" aria-expanded="false" aria-label="Toggle navigation">
                        <span className="navbar-toggler-icon"></span>
                    </button>

                    <div className="collapse navbar-collapse" id="navbarsExampleDefault">
                        <ul className="navbar-nav ml-auto">
                            <li className="nav-item">
                                <a className="nav-link" href="#">Marsito Kusmawati</a>
                            </li>
                            <li className="nav-item">
                                <Link to="/" className="nav-link">Login</Link>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>

            <main>
                <header className="jumbotron">
                    <div className="container">
                        <h1 className="display-4">Cars</h1>
                    </div>
                </header>

                <div className="container mb-5">

                    <div className="section-header mb-4">
                        <h4 className="section-title text-muted font-weight-normal">List of Cars</h4>
                    </div>

                    <div className="section-body">

                        {installment.map((insta, idx) => (
                            <article key={idx} className="spot">
                                <div className="row">
                                    <div className="col-5">
                                        <h5 className="text-primary">{insta.car}</h5>
                                        <span className="text-muted">{insta.description}</span>
                                    </div>
                                    <div className="col-4">
                                        <h5>Available Month</h5>
                                        <span className="text-muted">
                                            {insta.available_month.map((month, idx) => (
                                                <span>{month.month}, </span>
                                            ))} 
                                        Month
                                        </span>
                                    </div>
                                    <div className="col-3">
                                        <button onClick={() => navigate(`/list/instalment/${insta.id}`)} className="btn btn-danger btn-lg btn-block">
                                            Detail
                                        </button>
                                    </div>
                                </div>
                            </article>
                        ))}
                    </div>

                </div>

            </main>

            <footer>
                <div className="container">
                    <div className="text-center py-4 text-muted">
                        Copyright &copy; 2024 - Web Tech ID
                    </div>
                </div>
            </footer>
        </>
    )
}
