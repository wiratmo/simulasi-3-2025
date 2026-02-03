import { useNavigate } from "react-router-dom"
import { baseUrl } from "../../api/api"
import { useState } from "react"

export default function Main({ children }) {
    const [loading, setLoading] = useState('Logout')
    const token = localStorage.getItem('token')
    const username = localStorage.getItem('username')
    const nav = useNavigate()

    const handleLogout = async () => {
        setLoading('Logging-out')
        try {
            const res = await baseUrl.post('auth/logout')

            if (res.status == 200) {
                localStorage.removeItem('token')
                nav('/login')
            }
        } catch (e) {
            console.log(e.response.data)
        } finally {
            setLoading('Logout')
        }
    }
    return (
        <>
            <nav class="navbar navbar-expand-md navbar-dark fixed-top bg-primary">
                <div class="container">
                    <a class="navbar-brand" href="/">Installment Cars</a>
                    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarsExampleDefault" aria-controls="navbarsExampleDefault" aria-expanded="false" aria-label="Toggle navigation">
                        <span class="navbar-toggler-icon"></span>
                    </button>

                    <div class="collapse navbar-collapse" id="navbarsExampleDefault">
                        <ul class="navbar-nav ml-auto">
                            {token && (
                            <li class="nav-item">
                                <a class="nav-link" href="#">{username}</a>
                            </li>
                            )}
                            <li class="nav-item">
                                {token ? (
                                    <p onClick={() => handleLogout()} style={{ cursor: 'pointer' }} class="nav-link">{loading}</p>
                                ) : (
                                    <a class="nav-link" href="#">Login</a>
                                )}
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>

            {children}

            <footer>
                <div class="container">
                    <div class="text-center py-4 text-muted">
                        Copyright &copy; 2024 - Web Tech ID
                    </div>
                </div>
            </footer>
        </>
    )
}