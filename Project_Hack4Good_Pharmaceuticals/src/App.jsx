import {Routes, Route } from 'react-router-dom'
import Main from './components/Main.jsx'
import Search from './components/SearchPage/Search.jsx'
import Header from './components/Header.jsx'
import Footer from './components/Footer.jsx'
import Admin from './components/AdminPanel/Admin.jsx'
import './App.css'

function App() {
  
  return (
    <>
    <Header />
    <Routes>
      <Route path='/' element={<Main />}/>
      <Route path='/search' element={<Search />}/>
      <Route path='/admin' element={<Admin/>}/>
    </Routes>
    <Footer/>
    </>
  )
}

export default App
