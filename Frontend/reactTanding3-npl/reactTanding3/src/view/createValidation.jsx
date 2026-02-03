import axios from "axios"
import { useEffect } from "react"
import { useState } from "react"
import { baseUrl, loginEndpoint, validationEndpoint } from "../utils/api"
import { useNavigate } from "react-router-dom"

export default function CreateValidation() {
    const navigate = useNavigate()
    const [input, setInput] = useState()
    const [loading, setLoading] = useState(false)
    const token = localStorage.getItem('token')
    console.log(input)

    useEffect(() => {
        if (loading) {
            document.title = 'loading...'
        } else {
            document.title = 'login'
        }
    }, [loading])

    const handleChange = (event) => {
        const name = event.target.name
        const value = event.target.value
        setInput((values) => ({ ...values, [name]: value }))
    }

    const handleSubmit = async (event) => {
        event.preventDefault()
        setLoading(true)
        try {
            const res = await axios.post(baseUrl + validationEndpoint, input, {
                headers: {
                    Authorization: `Bearer ${token}`
                }
            })
            setInput(res.data)
            alert(res.data.message)
            navigate('/')
        } catch (e) {
            const errors = e.response.data.errors
            if (e.response) {

                if (e.response.status === 422) {
                    if (errors.job) {
                        alert(errors.job)
                    }
                    if (errors.job_description) {
                        alert(errors.job_description)
                    }
                    if (errors.income) {
                        alert(errors.income)
                    }
                    if (errors.reason_accepted) {
                        alert(errors.reason_accepted)
                    }
                }
                if (e.response.status === 401) {
                    alert(e.response.data.message)
                    window.location.href = '/login'
                }
                alert(e.response.data.message)
            } else {
                alert('kesalahan pada servel huhu')
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
                                <a className="nav-link" href="#">Login</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>

            <main>

                <header className="jumbotron">
                    <div className="container">
                        <h1 className="display-4">Request Data Validation</h1>
                    </div>
                </header>


                <div className="container">

                    <form action=""  onSubmit={handleSubmit}>
                        <div className="row mb-4">

                            <div className="col-md-6">
                                <div className="form-group">
                                    <input type="text" name="job" onChange={handleChange} placeholder="Your Job" className="form-control mt-2 mb-2" />
                                    <textarea className="form-control" name="job_description" onChange={handleChange} cols="30" rows="5" placeholder="describe what you do in your job"></textarea>
                                    <input type="number" name="income" onChange={handleChange} placeholder="Income (Rp)" className="form-control mt-2" />
                                </div>
                            </div>

                            <div className="col-md-12">
                                <div className="form-group">
                                    <div className="d-flex align-items-center mb-3">
                                        <label className="mr-3 mb-0">Reason Accepted</label>
                                    </div>
                                    <textarea name="reason_accepted" onChange={handleChange} className="form-control" cols="30" rows="6" placeholder="Explain why you should be accepted"></textarea>
                                </div>
                            </div>
                        </div>

                        <button className="btn btn-primary">Send Request</button>
                    </form>
                </div>
            </main>


            <footer>
                <div className="container">
                    <div className="text-center py-4 text-muted">
                        Copyright &copy; 2024 - Web Tech ID
                    </div>
                </div>
            </footer>


        </div>
    )
}