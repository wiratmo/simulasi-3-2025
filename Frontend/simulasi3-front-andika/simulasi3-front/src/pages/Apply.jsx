import { useEffect, useState } from "react"
import { useNavigate, useParams } from "react-router-dom"
import { baseUrl } from "../api/api"

export default function Apply() {
    const [installment, setInstalment] = useState({})
    const [nominal, setNominal] = useState('')
    const [months, setMonths] = useState('')
    const [notes, setNotes] = useState('')
    const [loading, setLoading] = useState('Submit')
    const [status, setStatus] = useState('')
    const [error, setError] = useState([])
    const [message, setMessage] = useState()
    const nav = useNavigate()

    const { id } = useParams()

    useEffect(() => {
        fetchInstallment()
    }, [])

    const fetchInstallment = async () => {
        try {
            const res = await baseUrl.get(`instalment_cars/${id}`)

            setInstalment(res.data.installment)

            console.log(res.data.installment)
        } catch (e) {
            console.log(e.response.data)
        }
    }

    const handleSubmit = async (e) => {
        e.preventDefault()
        setLoading('Submitting')
        try {
            const res = await baseUrl.post('applications', { installment_id: id, months: months, notes: notes })

            if (res.status == 200) {
                setStatus('success')
                setMessage(res.data.message)
                setMonths
            }
        } catch (e) {
            console.log(e.response.date)
            if (e.response.status == 422) {
                setError(e.response.data.error)
            } else {
                setMessage(e.response.data.message)
            }
            setStatus('failed')
        } finally {
            setLoading('Submit')
        }
    }
    return (
        <>
            <main>
                <header class="jumbotron">
                    <div class="container text-center">
                        <div>
                            <h1 class="display-4">{installment.cars}</h1>
                            <span class="text-muted">Brand : {installment?.brand?.brand}</span>
                        </div>
                    </div>
                </header>

                {status == 'failed' && message && (
                    <div className="alert-danger p-4 mb-5 d-flex justify-content-between">
                        <div>{message}</div>
                        <div style={{ cursor: 'pointer' }} onClick={() => setMessage('')}>x</div>
                    </div>
                )}
                {status == 'success' && message && (
                    <div className="alert-success p-4 mb-5 d-flex justify-content-between">
                        <div>{message}</div>
                        <div style={{ cursor: 'pointer' }} onClick={() => setMessage('')}>x</div>
                    </div>
                )}

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

                    <form onSubmit={handleSubmit} class="row mb-3">
                        <div class="col-md-12">
                            <div class="form-group">
                                <h3>Select Months</h3>
                                {error?.months?.map((e) => (
                                    <p className="text-danger">{e}</p>
                                ))}
                                <select name="months" class="form-control" value={months} onChange={(e) => setMonths(e.target.value)}>
                                    {installment?.available_months?.map((m) => (
                                        <option value={m.id}>{m.month} Months</option>
                                    ))}
                                </select>
                            </div>
                        </div>
                        <div class="col-md-12">
                            <div class="form-group">
                                <h3>Nominal/Month : <span class="badge badge-primary">Rp. 10.000.000</span></h3>
                            </div>
                        </div>

                        <div class="col-md-12">
                            <div class="form-group">
                                <div class="d-flex align-items-center mb-3">
                                    <label class="mr-3 mb-0">Notes</label>
                                </div>
                                {error?.notes?.map((e) => (
                                    <p className="text-danger">{e}</p>
                                ))}
                                <textarea value={notes} onChange={(e) => setNotes(e.target.value)} class="form-control" cols="30" rows="6" placeholder="Explain why your installment should be approved"></textarea>
                            </div>
                        </div>
                        <div class="col-md-12">
                            <div class="form-group">
                                <div class="d-flex align-items-center mb-3">
                                    <button class="btn btn-primary btn-lg">{loading}</button>
                                </div>
                            </div>
                        </div>
                    </form>

                </div>

            </main>
        </>
    )
}