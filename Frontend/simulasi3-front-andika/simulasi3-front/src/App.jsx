import { useState } from 'react'

import './App.css'
import { BrowserRouter } from 'react-router-dom'
import RouteList from './routes/RouteList'

function App() {
  const [count, setCount] = useState(0)

  return (
    <>
      <RouteList />
    </>
  )
}

export default App
