import './App.css';
import Content from './Content';
import {useContext} from 'react'
import {ThemeContext} from './ThemeContext'

function App() {
  const context = useContext(ThemeContext)

  return (
    <div>
      <button
        style={{ padding: '10px', margin: '10px' }}
        onClick = {context.ToggleTheme}
      >Toggle theme</button>
      <Content />
    </div>
  )
}

export default App;
