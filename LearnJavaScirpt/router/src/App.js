import {Route, Routes, Link} from 'react-router-dom'

import Home from './pages/Home'
import Contact from './pages/Contact'
import News from './pages/News'

function App () {
  return (
    <div>
    <nav>
    <ul>
      <li><Link to = '/'>Home</Link></li>
      <li><Link to = '/Contact'>Contact</Link></li>
      <li><Link to = '/News'>News</Link></li>
    </ul>
    </nav>
    
    <Routes>
      <Route path = '/' element = {<Home/>}/>
      <Route path = '/Contact' element = {<Contact/>}/>
      <Route path = '/News' element = {<News/>}/>
    </Routes>
    </div>
  )
}

export default App