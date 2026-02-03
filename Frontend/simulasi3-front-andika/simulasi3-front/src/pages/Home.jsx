import { useEffect, useState } from "react"
import { baseUrl } from "../api/api"

export default function Home() {
    const [validation, setValidation] = useState({})
    const [applications, setApplications] = useState([])
    useEffect(() => {
        fetchValidation()
        fetchApply()
    }, [])

    const fetchValidation = async () => {
        try {
            const res = await baseUrl.get('validations')

            setValidation(res.data.validation)

            console.log(res.data.validation)
        } catch (e) {
            console.log(e.response.data)
        }
    }
    const fetchApply = async () => {
        try {
            const res = await baseUrl.get('applications')

            setApplications(res.data.instalments)

            console.log(res.data.instalments)
        } catch (e) {
            console.log(e.response.data)
        }
    }
    return (
        <>
            <main>
                <header class="jumbotron">
                    <div class="container">
                        <h1 class="display-4">Dashboard</h1>
                    </div>
                </header>

                <div class="container">

                    <section class="validation-section mb-5">
                        <div class="section-header mb-3">
                            <h4 class="section-title text-muted">My Data Validation</h4>
                        </div>
                        <div class="row">

                            {!validation || validation.status == 'accepted' && (
                                <div class="col-md-4">
                                    <div class="card card-default">
                                        <div class="card-header">
                                            <h5 class="mb-0">Data Validation</h5>
                                        </div>
                                        <div class="card-body">
                                            <a href="/validation/add" class="btn btn-primary btn-block">+ Request validation</a>
                                        </div>
                                    </div>
                                </div>
                            )}

                            {validation && (
                                <div class="col-md-4">
                                    <div class="card card-default">
                                        <div class="card-header border-0">
                                            <h5 class="mb-0">Data Validation</h5>
                                        </div>
                                        <div class="card-body p-0">
                                            <table class="table table-striped mb-0">
                                                <tr>
                                                    <th>Status</th>
                                                    <td><span class={`badge badge-${validation.status == 'pending' ? 'info' : validation.status == 'declined' ? 'danger' : 'success'}`}>{validation.status}</span></td>
                                                </tr>
                                                <tr>
                                                    <th>Job</th>
                                                    <td class="text-muted">{validation.job ? validation.job : '-'}</td>
                                                </tr>
                                                <tr>
                                                    <th>Income/Month</th>
                                                    <td class="text-muted">{validation.income ? validation.income : '-'}</td>
                                                </tr>
                                                <tr>
                                                    <th>Validator</th>
                                                    <td class="text-muted">{validation.validator ? validation.validator : '-'}</td>
                                                </tr>
                                                <tr>
                                                    <th>Validator Notes</th>
                                                    <td class="text-muted">{validation.validator_notes ? validation.validator_notes : '-'}</td>
                                                </tr>
                                            </table>
                                        </div>
                                    </div>
                                </div>
                            )}
                        </div>
                    </section>

                    <section class="validation-section mb-5">
                        <div class="section-header mb-3">
                            <div class="row">
                                <div class="col-md-8">
                                    <h4 class="section-title text-muted">My Installment Cars</h4>
                                </div>
                                <div class="col-md-4">
                                    <a href="/installments" class="btn btn-primary btn-lg btn-block">+ Add Installment Cars</a>
                                </div>
                            </div>
                        </div>
                        <div class="section-body">
                            <div class="row mb-4">

                                <div class="col-md-12">
                                    <div class="alert alert-warning">
                                        Your validation must be approved by validator to Installment Cars.
                                    </div>
                                </div>

                                {applications?.map((app) => (
                                    <div class="col-md-6">
                                        <div class="card card-default">
                                            <div class="card-header border-0">
                                                <h5 class="mb-0">{app.car}</h5>
                                            </div>
                                            <div class="card-body p-0">
                                                <table class="table table-striped mb-0">
                                                    <tr>
                                                        <th>Description</th>
                                                        <td class="text-muted">{app.description}</td>
                                                    </tr>
                                                    <tr>
                                                        <th>Price</th>
                                                        <td class="text-muted">{app.price}</td>
                                                    </tr>
                                                    <tr>
                                                        <th>Installment</th>
                                                        <td class="text-muted">
                                                            {app?.application.month} Months <span class={`badge badge-${app?.application?.apply_status == 'pending' ? 'info' : app?.application?.apply_status == 'rejected' ? 'danger' : 'success'}`}>{app?.application.apply_status}</span>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <th>Apply Date</th>
                                                        <td class="text-muted">{app?.application.date}</td>
                                                    </tr>
                                                    <tr>
                                                        <th>Notes</th>
                                                        <td class="text-muted">{app?.application.note}</td>
                                                    </tr>
                                                </table>
                                            </div>
                                        </div>
                                    </div>
                                ))}
                            </div>
                        </div>
                    </section>
                </div >
            </main >
        </>
    )
}