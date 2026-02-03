import { Navigate, Route, Routes } from "react-router-dom";
import Login from "../pages/Login";
import Main from "../pages/layout/Main";
import Home from "../pages/Home";
import Validation from "../pages/Validation";
import Installment from "../pages/Installment";
import Apply from "../pages/Apply";

export default function RouteList() {

    const ProtectedRoute = ({ children }) => {
        const token = localStorage.getItem('token')

        if (!token) return <Navigate to={'/login'} replace />

        return children
    }
    return (
        <>
            <Routes>
                <Route path={'/login'} element={
                    <Main>
                        <Login />
                    </Main>
                } />
                <Route path={'/'} element={
                    <ProtectedRoute>
                        <Main>
                            <Home />
                        </Main>
                    </ProtectedRoute>
                } />
                <Route path={'/validation/add'} element={
                    <ProtectedRoute>
                        <Main>
                            <Validation />
                        </Main>
                    </ProtectedRoute>
                } />
                <Route path={'/installments'} element={
                    <ProtectedRoute>
                        <Main>
                            <Installment />
                        </Main>
                    </ProtectedRoute>
                } />
                <Route path={'/apply/:id'} element={
                    <ProtectedRoute>
                        <Main>
                            <Apply />
                        </Main>
                    </ProtectedRoute>
                } />
            </Routes>
        </>
    )
}