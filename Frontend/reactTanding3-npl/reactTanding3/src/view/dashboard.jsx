import axios from "axios"
import { useState } from "react"
import { baseUrl, validationEndpoint } from "../utils/api"
import { useEffect } from "react"

export default function Dashboard() {
    const [validation, setValidation] = useState()
    const token = localStorage.getItem('token')
    const [loading, setLoading] = useState(false)

    useEffect(() => {
        if (loading) {
            document.title = 'loading...'
        } else {
            document.title = 'Dashboard'
        }
    }, [loading])

    useEffect(() => {
        getValidation()
    }, [])

    const getValidation = async () => {
        setLoading(true)
        try {
            const res = await axios.get(baseUrl + validationEndpoint, {
                headers: {
                    Authorization: `Bearer ${token}`
                }
            })
            setValidation(res.data.validation)
        } catch (e) {
            if (e.response) {
                if (e.response.status === 401) {
                    window.location.href = '/login'
                }
            } else {
                alert('error server')
            }
        } finally {
            setLoading(false)
        }
    }

    return (
        <div>
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
                                <a className="nav-link" href="#">Logout</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>

            <main>
                {/* <!-- S: Header --> */}
                <header className="jumbotron">
                    <div className="container">
                        <h1 className="display-4">Dashboard</h1>
                    </div>
                </header>
                {/* <!-- E: Header --> */}

                <section className="container">

                    {/* <!-- S: Data Validation Section --> */}
                    <section className="validation-section mb-5">
                        <div className="section-header mb-3">
                            <h4 className="section-title text-muted">My Data Validation</h4>
                        </div>
                        <div className="row">

                            {/* <!-- S: Link to Request Data Validation --> */}
                            <div className="col-md-4">
                                <div className="card card-default">
                                    <div className="card-header">
                                        <h5 className="mb-0">Data Validation</h5>
                                    </div>
                                    <div className="card-body">
                                        <a href="/create-validation" className="btn btn-primary btn-block">+ Request validation</a>
                                    </div>
                                </div>
                            </div>
                            {/* <!-- E: Link to Request Data Validation -->

                                <!-- S: Society Data Validation Box (Pending) --> */}
                            <div className="col-md-4">
                                <div className="card card-default">
                                    <div className="card-header border-0">
                                        <h5 className="mb-0">Data Validation</h5>
                                    </div>
                                    <div className="card-body p-0">
                                        {
                                            !validation ? "" : (

                                                <table class="table table-striped mb-0">
                                                    <tr>
                                                        <th>Status</th>
                                                        <td><span className={validation?.status === 'accepted' ? 'badge badge-success' : 'badge badge-info'}>{validation.status}</span></td>
                                                    </tr>
                                                    <tr>
                                                        <th>Job</th>
                                                        <td class="text-muted">{validation.job}</td>
                                                    </tr>
                                                    <tr>
                                                        <th>Income/Month</th>
                                                        <td class="text-muted">{validation.income}</td>
                                                    </tr>
                                                    <tr>
                                                        <th>Validator</th>
                                                        <td class="text-muted">{validation.validator_id}</td>
                                                    </tr>
                                                    <tr>
                                                        <th>Validator Notes</th>
                                                        <td class="text-muted">{validation.validator_note}</td>
                                                    </tr>
                                                </table>
                                            )
                                        }
                                    </div>
                                </div>
                            </div>
                        </div>
                    </section>
                    {/* <!-- E: Data Validation Section -->

                        <!-- S: List Job Seekers Section --> */}
                    <section className="validation-section mb-5">
                        <div className="section-header mb-3">
                            <div className="row">
                                <div className="col-md-8">
                                    <h4 className="section-title text-muted">My Installment Cars</h4>
                                </div>
                                <div className="col-md-4">
                                    <a href="/list-cars" className="btn btn-primary btn-lg btn-block">+ Add Installment Cars</a>
                                </div>
                            </div>
                        </div>
                        <div className="section-body">
                            <div className="row mb-4">

                                {/* <!-- S: Installment Cars info --> */}
                                <div className="col-md-12">
                                    <div className="alert alert-warning">
                                        Your validation must be approved by validator to Installment Cars.
                                    </div>
                                </div>
                                {/* <!-- E: Installment Cars info -->

                                    <!-- S: Installment Cars Box (Registered) --> */}
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
                                {/* <!-- S: Installment Cars Box (Registered) -->
                                    <!-- S: Installment Cars Box (Registered) --> */}
                                <div className="col-md-6">
                                    <div className="card card-default">
                                        <div className="card-header border-0">
                                            <h5 className="mb-0">Nissan Livina</h5>
                                        </div>
                                        <div className="card-body p-0">
                                            {/* <table className="table table-striped mb-0">
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
                                                </table> */}
                                        </div>
                                    </div>
                                </div>
                                {/* <!-- S: Installment Cars Box (Registered) --> */}

                            </div>
                        </div>
                    </section>

                </section>
                {/* <!-- E: List Job Seekers Section --> */}
            </main >

            {/* < !--S: Footer-- > */}
            <footer>
                <div className="container">
                    <div className="text-center py-4 text-muted">
                        Copyright &copy; 2024 - Web Tech ID
                    </div>
                </div>
            </footer>
            {/* <!--E: Footer-- > */}

        </div >
    )
}