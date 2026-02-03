import { useState } from "react"
import { baseUrl } from "../api/api"
import { useNavigate } from "react-router-dom"

export default function Login() {
    const [id_card_number, setCardNumber] = useState('')
    const [password, setPassword] = useState('')
    const [loading, setLoading] = useState('Login')
    const [status, setStatus] = useState('')
    const [error, setError] = useState([])
    const [message, setMessage] = useState()
    const nav = useNavigate()

    const handlePost = async (e) => {
        e.preventDefault()
        setLoading('Logging-in')
        try {
            const res = await baseUrl.post('auth/login', { id_card_number, password })
            setLoading('Logging-in')
            if (res.status == 200) {
                localStorage.setItem('token', res.data.token)
                localStorage.setItem('username', res.data.name)
                setStatus('success')
                nav('/')
            }
            console.log(res.data)
        } catch (e) {
            console.log(e.response.data)
            if (e.response.status == 422) {
                setError(e.response.data.error)
            } else {
                setMessage(e.response.data.message)
            }
            setStatus('failed')
        } finally {
            setLoading('Login')
        }
    }
    return (
        <>
            <main>
                <header className="jumbotron">
                    <div className="container text-center">
                        <h1 className="display-4">Installment Cars</h1>
                    </div>
                </header>

                {status == 'failed' && message && (
                    <div className="alert-danger p-4 mb-5 d-flex justify-content-between">
                        <div>{message}</div>
                        <div style={{cursor: 'pointer'}} onClick={() => setMessage('')}>x</div>
                    </div>
                )}

                <div className="container">
                    <div className="row justify-content-center">
                        <div className="col-md-6">
                            <form onSubmit={handlePost} className="card card-default">
                                <div className="card-header">
                                    <h4 className="mb-0">Login</h4>
                                </div>
                                <div className="card-body">
                                    <div className="form-group row align-items-center">
                                        <div className="col-4 text-right">ID Card Number</div>
                                        <div className="col-8">
                                            {error?.id_card_number?.map((e) => (
                                                <p className="text-danger">{e}</p>
                                            ))}
                                            <input type="text" className="form-control"
                                                value={id_card_number} onChange={(e) => setCardNumber(e.target.value)}
                                            />
                                        </div>
                                    </div>
                                    <div className="form-group row align-items-center">
                                        <div className="col-4 text-right">Password</div>
                                        <div className="col-8">
                                            {error?.password?.map((e) => (
                                                <p className="text-danger">{e}</p>
                                            ))}
                                            <input type="password" className="form-control"
                                                value={password} onChange={(e) => setPassword(e.target.value)}
                                            />
                                        </div>
                                    </div>
                                    <div className="form-group row align-items-center mt-4">
                                        <div className="col-4"></div>
                                        <div className="col-8"><button className="btn btn-primary">{loading}</button></div>
                                    </div>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
            </main>
        </>
    )
}