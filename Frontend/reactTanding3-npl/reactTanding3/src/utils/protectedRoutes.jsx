import { useNavigate } from "react-router-dom"

export default function ProtectedRoutes({children:child}){
    const token = localStorage.getItem('token')

    if(!token){
        window.location.href = '/login'
    }

    return(
        <>
            {child}
        </>
    )
}