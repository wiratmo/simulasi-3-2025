import axios from "axios"
import { useState } from "react"
import { baseUrl, installmentEndpoint, validationEndpoint } from "../utils/api"
import { useEffect } from "react"
import { useParams } from "react-router-dom"

export default function ListCars() {
    const [installment, setInstallment] = useState([])
    const token = localStorage.getItem('token')
    const [loading, setLoading] = useState(false)

    console.log(installment)

    useEffect(() => {
        if (loading) {
            document.title = 'loading...'
        } else {
            document.title = 'List Cars'
        }
    }, [loading])

    useEffect(() => {
        getInstallment()
    }, [])

    const getInstallment = async () => {
        setLoading(true)
        try {
            const res = await axios.get(baseUrl + installmentEndpoint, {
                headers: {
                    Authorization: `Bearer ${token}`
                }
            })
            setInstallment(res.data.cars)
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
            <nav class="navbar navbar-expand-md navbar-dark fixed-top bg-primary">
                <div class="container">
                    <a class="navbar-brand" href="#">Installment Cars</a>
                    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarsExampleDefault" aria-controls="navbarsExampleDefault" aria-expanded="false" aria-label="Toggle navigation">
                        <span class="navbar-toggler-icon"></span>
                    </button>

                    <div class="collapse navbar-collapse" id="navbarsExampleDefault">
                        <ul class="navbar-nav ml-auto">
                            <li class="nav-item">
                                <a class="nav-link" href="#">Marsito Kusmawati</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="#">Login</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>

            <main>

                <header class="jumbotron">
                    <div class="container">
                        <h1 class="display-4">Cars</h1>
                    </div>
                </header>


                <div class="container mb-5">

                    <div class="section-header mb-4">
                        <h4 class="section-title text-muted font-weight-normal">List of Cars</h4>
                    </div>

                    <div class="section-body">

                        {
                            installment.map((car, index) => (
                                <article key={index} class="spot">
                                    <div class="row">
                                        <div class="col-5">
                                            <h5 class="text-primary">{car.cars}</h5>
                                            <span class="text-muted">{car.description}</span>
                                        </div>
                                        <div class="col-4">
                                            <h5>Available Month</h5>
                                            <span class="text-muted">{car.available_month.month} Months</span>
                                        </div>
                                        <div class="col-3">
                                            <button onClick={() => window.location.href = 'detail-cars/'+car.id} class="btn btn-danger btn-lg btn-block">
                                                Detail
                                            </button>
                                        </div>
                                    </div>
                                </article>
                            ))
                        }
                    </div>

                </div>

            </main>

            <footer>
                <div class="container">
                    <div class="text-center py-4 text-muted">
                        Copyright &copy; 2024 - Web Tech ID
                    </div>
                </div>
            </footer>
        </div>
    )
}