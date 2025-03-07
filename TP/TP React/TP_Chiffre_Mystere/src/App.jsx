import { useState } from 'react'
import './App.css'
import MysteryNumber from './components/MysteryNumber'

function App() {
  const [count, setCount] = useState(0)

  return (
    <>
      <MysteryNumber nbMystere={10} />
    </>
  )
}

export default App
