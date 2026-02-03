import axios from "axios"
import { useEffect } from "react"
import { useState } from "react"
import { baseUrl, loginEndpoint } from "../utils/api"
import { useNavigate } from "react-router-dom"

export default function Login() {
    const navigate = useNavigate()
    const [input, setInput] = useState()
    const [loading, setLoading] = useState(false)

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
            const res = await axios.post(baseUrl + loginEndpoint, input)
            setInput(res.data)
            localStorage.setItem('token', res.data.token)
            navigate('/')
        } catch (e) {
            const errors = e.response.data.errors
            if (e.response) {

                if (e.response.status === 422) {
                    if (errors.id_card_number) {
                        alert(errors.id_card_number)
                    }
                    if (errors.password) {
                        alert(errors.password)
                    }
                }
                if (e.response.status === 401) {
                    alert(e.response.data.message)
                }
            }else{
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
                {/* <!-- S: Header --> */}
                <header className="jumbotron">
                    <div className="container text-center">
                        <h1 className="display-4">Installment Cars</h1>
                    </div>
                </header>
                {/* <!-- E: Header --> */}

                <div className="container">
                    <div className="row justify-content-center">
                        <div className="col-md-6">
                            <form onSubmit={handleSubmit} className="card card-default">
                                <div className="card-header">
                                    <h4 className="mb-0">Login</h4>
                                </div>
                                <div className="card-body">
                                    <div className="form-group row align-items-center">
                                        <div className="col-4 text-right">ID Card Number</div>
                                        <div className="col-8"><input type="text" name="id_card_number" onChange={handleChange} className="form-control" /></div>
                                    </div>
                                    <div className="form-group row align-items-center">
                                        <div className="col-4 text-right">Password</div>
                                        <div className="col-8"><input type="password" name="password" onChange={handleChange} className="form-control" /></div>
                                    </div>
                                    <div className="form-group row align-items-center mt-4">
                                        <div className="col-4"></div>
                                        <div className="col-8"><button type="submit" className="btn btn-primary">Login</button></div>
                                    </div>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
            </main>

            {/* <!-- S: Footer --> */}
            <footer>
                <div className="container">
                    <div className="text-center py-4 text-muted">
                        Copyright &copy; 2024 - Web Tech ID
                    </div>
                </div>
            </footer>
            {/* <!-- E: Footer --> */}
        </div>
    )
}