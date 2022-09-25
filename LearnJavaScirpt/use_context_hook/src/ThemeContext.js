import { useState, createContext } from 'react'


const ThemeContext = createContext()



function ThemeProvider({ children }) {
    const [theme, setTheme] = useState('dark')
    const ToggleTheme = () => {
        setTheme(theme === 'dark' ? 'light' : 'dark')
    }

    const obj = {
        theme,
        ToggleTheme
    }
    return (
        <ThemeContext.Provider value={obj}>
            {children}
        </ThemeContext.Provider>

    )
}


export { ThemeProvider, ThemeContext }