import React, { useEffect, useState } from 'react'
import { Link, useParams } from 'react-router-dom'
import api from '../../services/api';

export default function DetailList() {
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState("");
    const [installment, setInstallment] = useState({});
    const { id } = useParams();

    const fetchCars = async() => {
        try {
            const res = await api.get(`/instalment_cars/${id}`);

            setInstallment(res.data.instalment);
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
        fetchCars();
    }, []);


    if(loading) {
        return (
            <>
                <div>Loading.....</div>
            </>
        )
    }

    return (
        <>
            <nav className="navbar navbar-expand-md navbar-dark fixed-top bg-primary">
                <div className="container">
                    <Link to="/list/instalment" className="navbar-brand" href="#">Installment Cars</Link>
                    <button className="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarsExampleDefault" aria-controls="navbarsExampleDefault" aria-expanded="false" aria-label="Toggle navigation">
                        <span className="navbar-toggler-icon"></span>
                    </button>

                    <div className="collapse navbar-collapse" id="navbarsExampleDefault">
                        <ul className="navbar-nav ml-auto">
                            <li className="nav-item">
                                <a className="nav-link" href="#">Marsito Kusmawati</a>
                            </li>
                            <li className="nav-item">
                                <a className="nav-link" href="#">Logout</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>

            <main>
                <header className="jumbotron">
                    <div className="container text-center">
                        <div>
                            <h1 className="display-4">{installment.car}</h1>
                            <span className="text-muted">Brand : {installment.brand}</span>
                        </div>
                    </div>
                </header>

                <div className="container">

                    <div className="row mb-3">
                        <div className="col-md-12">
                            <div className="form-group">
                                <h3>Description</h3>
                                {installment.description}
                            </div>
                        </div>
                        <div className="col-md-12">
                            <div className="form-group">
                                <h3>Price : <span className="badge badge-primary">Rp. {installment.price}</span></h3>
                            </div>
                        </div>
                    </div>

                    <div className="row mb-3">
                        <div className="col-md-12">
                            <div className="form-group">
                                <h3>Select Months</h3>
                                <select name="months" className="form-control">
                                    {installment.available_month.map((month, idx) => (
                                        <option value={month.month}>{month.month} Month</option>
                                    ))}
                                </select>
                            </div>
                        </div>
                        <div className="col-md-12">
                            <div className="form-group">
                                <h3>Nominal/Month : <span className="badge badge-primary">Rp. 10.000.000</span></h3>
                            </div>
                        </div>

                        <div className="col-md-12">
                            <div className="form-group">
                                <div className="d-flex align-items-center mb-3">
                                    <label className="mr-3 mb-0">Notes</label>
                                </div>
                                <textarea className="form-control" cols="30" rows="6" placeholder="Explain why your installment should be approved"></textarea>
                            </div>
                        </div>
                        <div className="col-md-12">
                            <div className="form-group">
                                <div className="d-flex align-items-center mb-3">
                                    <button className="btn btn-primary btn-lg">Apply</button>
                                </div>
                            </div>
                        </div>
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
