import { useState } from "react"
import { useNavigate } from "react-router-dom"
import { baseUrl } from "../api/api"

export default function Validation() {
    const [haveJob, setHaveJob] = useState('yes')
    const [job, setJob] = useState('')
    const [job_description, setJobDescription] = useState('')
    const [income, setIncome] = useState('')
    const [reason_accepted, setReason] = useState('')
    const [loading, setLoading] = useState('Send Request')
    const [status, setStatus] = useState('')
    const [error, setError] = useState([])
    const [message, setMessage] = useState()
    const nav = useNavigate()

    const handleSubmit = async (e) => {
        e.preventDefault()
        setLoading('Sending...')
        try {
            const res = await baseUrl.post('validations', { job, job_description, income, reason_accepted })

            if (res.status == 200) {
                setStatus('success')
                setMessage(res.data.message)
                setJob('')
                setJobDescription('')
                setIncome('')
                setReason('')
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
            setLoading('Send Request')
        }
    }
    return (
        <>
            <main>
                <header class="jumbotron">
                    <div class="container">
                        <h1 class="display-4">Request Data Validation</h1>
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

                    <form onSubmit={handleSubmit} action="">
                        <div class="row mb-4">

                            <div class="col-md-6">
                                <div class="form-group">
                                    <div class="d-flex align-items-center mb-3">
                                        <label class="mr-3 mb-0">Are you working?</label>
                                        <select class="form-control-sm" onChange={(e) => setHaveJob(e.target.value)}>
                                            <option value="yes">Yes, I have</option>
                                            <option value="no">No</option>
                                        </select>
                                    </div>
                                    {haveJob == 'yes' && (
                                        <>
                                            {error?.job?.map((e) => (
                                                <p className="text-danger">{e}</p>
                                            ))}
                                            <input value={job} onChange={(e) => setJob(e.target.value)} type="text" placeholder="Your Job" class="form-control mt-2 mb-2" />
                                            {error?.job_description?.map((e) => (
                                                <p className="text-danger">{e}</p>
                                            ))}
                                            <textarea value={job_description} onChange={(e) => setJobDescription(e.target.value)} class="form-control" cols="30" rows="5" placeholder="describe what you do in your job"></textarea>
                                            {error?.income?.map((e) => (
                                                <p className="text-danger">{e}</p>
                                            ))}
                                            <input value={income} onChange={(e) => setIncome(e.target.value)} type="number" placeholder="Income (Rp)" class="form-control mt-2" />
                                        </>
                                    )}
                                </div>
                            </div>

                            <div class="col-md-12">
                                <div class="form-group">
                                    <div class="d-flex align-items-center mb-3">
                                        <label class="mr-3 mb-0">Reason Accepted</label>
                                    </div>
                                    {error?.reason_accepted?.map((e) => (
                                        <p className="text-danger">{e}</p>
                                    ))}
                                    <textarea value={reason_accepted} onChange={(e) => setReason(e.target.value)} class="form-control" cols="30" rows="6" placeholder="Explain why you should be accepted"></textarea>
                                </div>
                            </div>
                        </div>
                        {reason_accepted && (
                            <button class="btn btn-primary">{loading}</button>
                        )}
                    </form>

                </div>

            </main>
        </>
    )
}