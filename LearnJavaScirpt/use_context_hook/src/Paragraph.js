import {useContext} from 'react'
import {ThemeContext} from './ThemeContext'


function Paragraph() {
    let themeContext = useContext(ThemeContext)  
    return (
      <div>
        <h2 className={themeContext.theme}>
          Lorem ipsum, dolor sit amet consectetur adipisicing elit. Qui, illo
          minima repellendus non doloremque ea expedita veritatis architecto
          pariatur nemo quidem nobis at libero nam voluptatum ipsa, tempore
          maiores modi?
        </h2>
      </div>
    );
  }
  
  export default Paragraph
  