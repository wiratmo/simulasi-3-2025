import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import Dashboard from './view/dashboard'
import { BrowserRouter, Route, Routes } from 'react-router-dom'
import Login from './view/login'
import ProtectedRoutes from './utils/protectedRoutes'
import CreateValidation from './view/createValidation'
import ListCars from './view/listCars'
import DetailCars from './view/detailCars'

function App() {

  return (
    <BrowserRouter>
      <Routes>
        <Route path='/login' element={<Login/>}/>
        <Route index element={
          <ProtectedRoutes>
            <Dashboard/>
          </ProtectedRoutes>
          }/>
        <Route path='/create-validation' element={
          <ProtectedRoutes>
            <CreateValidation/>
          </ProtectedRoutes>
          }/>
        <Route path='/list-cars' element={
          <ProtectedRoutes>
            <ListCars/>
          </ProtectedRoutes>
          }/>
        <Route path='/detail-cars/:id' element={
          <ProtectedRoutes>
            <DetailCars/>
          </ProtectedRoutes>
          }/>
      </Routes>
    </BrowserRouter>
  )
}

export default App
