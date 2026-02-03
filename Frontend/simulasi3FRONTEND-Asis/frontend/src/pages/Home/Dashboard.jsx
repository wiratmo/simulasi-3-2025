import React, { useEffect } from 'react'
import { useState } from 'react'
import api from '../../services/api';
import { Link, useNavigate } from 'react-router-dom';

export default function Dashboard() {
    const navigate = useNavigate();
    const [error, setError] = useState("");
    const [validation, setValidation] = useState({});
    const [loadingData, setLoadingData] = useState(true);
    


    const fetchData = async() => {
        try {
            const res = await api.get("/validations");

            setValidation(res.data.validation);
            setLoadingData(false);
        } catch (err) {
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
    }, [])

    const handleLogout = async() => {
        try {
            const res = await api.post("/auth/logout");

        
            localStorage.clear();
            navigate("/");
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
                                <button onClick={() => handleLogout()} className="btn btn-outline-light" href="#">Logout</button>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>

            <main>
                <header className="jumbotron">
                    <div className="container">
                        <h1 className="display-4">Dashboard</h1>
                    </div>
                </header>

                {error && (
                    <div className="alert alert-danger mt-4">{error}</div>
                )}

                <div className="container">
                    <section className="validation-section mb-5">
                        <div className="section-header mb-3">
                            <h4 className="section-title text-muted">My Data Validation</h4>
                        </div>
                        <div className="row">
                            {validation && (
                                <div className="col-md-4">
                                    <div className="card card-default">
                                        <div className="card-header">
                                            <h5 className="mb-0">Data Validation</h5>
                                        </div>
                                        <div className="card-body">
                                            <Link to="/create/validation"  className="btn btn-primary btn-block">+ Request validation</Link>
                                        </div>
                                    </div>
                                </div>
                            )}
{/* 
                            <div className="col-md-4">
                                <div className="card card-default">
                                    <div className="card-header">
                                        <h5 className="mb-0">Data Validation</h5>
                                    </div>
                                    <div className="card-body">
                                        <Link to="/create/validation" className="btn btn-primary btn-block">+ Request validation</Link>
                                    </div>
                                </div>
                            </div> */}
                            <div className="col-md-4">
                                <div className="card card-default">
                                    <div className="card-header border-0">
                                        <h5 className="mb-0">Data Validation</h5>
                                    </div>
                                    <div className="card-body p-0">
                                        {loadingData ? (
                                            <div>Loading....</div>
                                        ) : validation.length === 0 ? (
                                            <div>Tidak ada</div>
                                        ) : (
                                            <table className="table table-striped mb-0">
                                                <tr>
                                                    <th>Status</th>
                                                    <td><span className="badge badge-success">{validation.status ?? "-"}</span></td>
                                                </tr>
                                                <tr>
                                                    <th>Job</th>
                                                    <td className="text-muted">{validation.job ?? "-"}</td>
                                                </tr>
                                                <tr>
                                                    <th>Income/Month</th>
                                                    <td className="text-muted">Rp. {validation.income ?? "-"}</td>
                                                </tr>
                                                <tr>
                                                    <th>Validator</th>
                                                    <td className="text-muted">{validation.validator ?? "-"}</td>
                                                </tr>
                                                <tr>
                                                    <th>Validator Notes</th>
                                                    <td className="text-muted">{validation.validator_notes ?? "-"}</td>
                                                </tr>
                                            </table>
                                        )}
                                    </div>
                                </div>
                            </div>
                            {/* <div className="col-md-4">
                                <div className="card card-default">
                                    <div className="card-header border-0">
                                        <h5 className="mb-0">Data Validation</h5>
                                    </div>
                                    <div className="card-body p-0">
                                        <table className="table table-striped mb-0">
                                            <tr>
                                                <th>Status</th>
                                                <td><span className="badge badge-success">Accepted</span></td>
                                            </tr>
                                            <tr>
                                                <th>Job</th>
                                                <td className="text-muted">Programmer</td>
                                            </tr>
                                            <tr>
                                                <th>Income/Month</th>
                                                <td className="text-muted">Rp. 3.000.000</td>
                                            </tr>
                                            <tr>
                                                <th>Validator</th>
                                                <td className="text-muted">Usman M.Ti</td>
                                            </tr>
                                            <tr>
                                                <th>Validator Notes</th>
                                                <td className="text-muted">siap kerja</td>
                                            </tr>
                                        </table>
                                    </div>
                                </div>
                            </div> */}
                        </div>
                    </section>
                    <section className="validation-section mb-5">
                        <div className="section-header mb-3">
                            <div className="row">
                                <div className="col-md-8">
                                    <h4 className="section-title text-muted">My Installment Cars</h4>
                                </div>
                                <div className="col-md-4">
                                    <Link to="/list/instalment" className="btn btn-primary btn-lg btn-block">+ Add Installment Cars</Link>
                                </div>
                            </div>
                        </div>
                        <div className="section-body">
                            <div className="row mb-4">

                                <div className="col-md-12">
                                    <div className="alert alert-warning">
                                        Your validation must be approved by validator to Installment Cars.
                                    </div>
                                </div>

                                <div className="col-md-6">
                                    <div className="card card-default">
                                        <div className="card-header border-0">
                                            <h5 className="mb-0">Toyota FT 86</h5>
                                        </div>
                                        <div className="card-body p-0">
                                            <table className="table table-striped mb-0">
                                                <tr>
                                                    <th>Description</th>
                                                    <td className="text-muted">Toyota FT 86 car is the best</td>
                                                </tr>
                                                <tr>
                                                    <th>Price</th>
                                                    <td className="text-muted">Rp. 900.000.000</td>
                                                </tr>
                                                <tr>
                                                    <th>Installment</th>
                                                    <td className="text-muted">
                                                        12 Months <span className="badge badge-info">Pending</span>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <th>Apply Date</th>
                                                    <td className="text-muted">Desember 12, 2024</td>
                                                </tr>
                                                <tr>
                                                    <th>Notes</th>
                                                    <td className="text-muted">I want this one, because i am rich.</td>
                                                </tr>
                                            </table>
                                        </div>
                                    </div>
                                </div>
                                <div className="col-md-6">
                                    <div className="card card-default">
                                        <div className="card-header border-0">
                                            <h5 className="mb-0">Nissan Livina</h5>
                                        </div>
                                        <div className="card-body p-0">
                                            <table className="table table-striped mb-0">
                                                <tr>
                                                    <th>Description</th>
                                                    <td className="text-muted">Family Cars for everyone</td>
                                                </tr>
                                                <tr>
                                                    <th>Price</th>
                                                    <td className="text-muted">Rp. 275.000.000</td>
                                                </tr>
                                                <tr>
                                                    <th>Installment</th>
                                                    <td className="text-muted">
                                                        24 Months <span className="badge badge-success">Accepted</span>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <th>Apply Date</th>
                                                    <td className="text-muted">Desember 12, 2024</td>
                                                </tr>
                                                <tr>
                                                    <th>Notes</th>
                                                    <td className="text-muted">I want this one too.</td>
                                                </tr>
                                            </table>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </section>
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
