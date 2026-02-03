import axios from "axios"
import { useState } from "react"
import { baseUrl, installmentEndpoint, validationEndpoint } from "../utils/api"
import { useEffect } from "react"
import { useParams } from "react-router-dom"

export default function DetailCars() {
    const {id} = useParams()
    const [installment, setInstallment] = useState({})
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
            const res = await axios.get(baseUrl + installmentEndpoint +'/'+id, {
                headers: {
                    Authorization: `Bearer ${token}`
                }
            })
            setInstallment(res.data.installment)
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
                                <a class="nav-link" href="#">Logout</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>

            <main>

                <header class="jumbotron">
                    <div class="container text-center">
                        <div>
                            <h1 class="display-4">{installment.cars}</h1>
                            <span class="text-muted">Brand : {installment.cars}</span>
                        </div>
                    </div>
                </header>


                <div class="container">

                    <div class="row mb-3">
                        <div class="col-md-12">
                            <div class="form-group">
                                <h3>Description</h3>
                                {installment.description}
                            </div>
                        </div>
                        <div class="col-md-12">
                            <div class="form-group">
                                <h3>Price : <span class="badge badge-primary">Rp. {installment.price}</span></h3>
                            </div>
                        </div>
                    </div>

                    <div class="row mb-3">
                        <div class="col-md-12">
                            <div class="form-group">
                                <h3>Select Months</h3>
                                <select name="months" class="form-control">
                                    <option value="">{installment.available_month?.month} Month</option>
                                </select>
                            </div>
                        </div>
                        <div class="col-md-12">
                            <div class="form-group">
                                <h3>Nominal/Month : <span class="badge badge-primary">Rp. {installment.available_month?.nominal}</span></h3>
                            </div>
                        </div>

                        <div class="col-md-12">
                            <div class="form-group">
                                <div class="d-flex align-items-center mb-3">
                                    <label class="mr-3 mb-0">Notes</label>
                                </div>
                                <textarea class="form-control" cols="30" rows="6" placeholder="Explain why your installment should be approved"></textarea>
                            </div>
                        </div>
                        <div class="col-md-12">
                            <div class="form-group">
                                <div class="d-flex align-items-center mb-3">
                                    <button class="btn btn-primary btn-lg">Apply</button>
                                </div>
                            </div>
                        </div>
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