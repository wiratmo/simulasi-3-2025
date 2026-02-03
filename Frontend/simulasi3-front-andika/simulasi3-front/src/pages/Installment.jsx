import { useEffect, useState } from "react"
import { baseUrl } from "../api/api"
import { useNavigate } from "react-router-dom"

export default function Installment() {
    const [instalments, setInstalments] = useState([])
    const [applications, setApplications] = useState([])
    const nav = useNavigate()
    useEffect(() => {
        fetchInstallments()
        fetchApply()
    }, [])

    const fetchInstallments = async () => {
        try {
            const res = await baseUrl.get('instalment_cars')

            setInstalments(res.data.cars)

            console.log(res.data.cars)
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
                        <h1 class="display-4">Cars</h1>
                    </div>
                </header>

                <div class="container mb-5">

                    <div class="section-header mb-4">
                        <h4 class="section-title text-muted font-weight-normal">List of Cars</h4>
                    </div>

                    <div class="section-body">
                        {instalments.map((i) => (
                            <article class={`spot }`}>
                                <div class="row">
                                    <div class="col-5">
                                        <h5 class="text-primary">{i.cars}</h5>
                                        <span class="text-muted">{i.description}</span>
                                    </div>
                                    <div class="col-4">
                                        <h5>Available Month</h5>
                                        <span class="text-muted">
                                            {i?.available_months?.map((m) => (<span className="d-flec ml-2">{m.month} Months,</span>))}
                                        </span>
                                    </div>
                                    <div class="col-3">
                                        <button onClick={() => nav(`/apply/${i.id}`)} class="btn btn-danger btn-lg btn-block">
                                            Detail
                                        </button>
                                    </div>
                                </div>
                            </article>
                        ))}
                        <article class="spot unavailable">
                            <div class="row">
                                <div class="col-5">
                                    <h5 class="text-primary">Nissan Livina</h5>
                                    <span class="text-muted">Family Cars for everyone</span>
                                </div>
                                <div class="col-4">
                                    <h5>Available Month</h5>
                                    <span class="text-muted">12 Months, 24 Months</span>
                                </div>
                                <div class="col-3">
                                    <div class="bg-success text-white p-2">
                                        Vacancies have been submitted
                                    </div>
                                </div>
                            </div>
                        </article>

                        <article class="spot unavailable">
                            <div class="row">
                                <div class="col-5">
                                    <h5 class="text-primary">Toyota FT 86</h5>
                                    <span class="text-muted">Toyota FT 86 car is the best</span>
                                </div>
                                <div class="col-4">
                                    <h5>Available Month</h5>
                                    <span class="text-muted">12 Months, 24 Months, 48 Months</span>
                                </div>
                                <div class="col-3">
                                    <button class="btn btn-danger btn-lg btn-block">
                                        Detail
                                    </button>
                                </div>
                            </div>
                        </article>
                    </div>

                </div>

            </main>

        </>
    )
}