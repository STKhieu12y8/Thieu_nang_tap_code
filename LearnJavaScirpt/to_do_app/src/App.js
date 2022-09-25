import { useRef } from 'react'
import { useStore, actions } from './store'

function App() {
  const inputEl = useRef()

  const [state, dispatch] = useStore()

  const { listTodo, inputTodo } = state

  const handleAddTodo = () => {
    if (inputTodo.trim() === '') {
      alert('Please enter todo')
    }
    else {
      dispatch(actions.addTodo(inputTodo))
    }
    dispatch(actions.setTodoInput(''))
    inputEl.current.focus()
  }

  return (
    <div >
      <input
        value={inputTodo}
        ref={inputEl}
        placeholder="enter todo..."
        onChange={(e) => {
          dispatch(actions.setTodoInput(e.target.value))
        }}
      />
      <button
        onClick={handleAddTodo}
      >
        add todo
      </button>

      <ul>
        {listTodo.map((todo, index) => (
          <li key={index}>{todo}
            <span style={{ marginLeft: 10, cursor: 'pointer' }} onClick={() => dispatch(actions.deleteTodo(index))}>xóa</span>
          </li>))}
      </ul>
    </div>
  );
}

export default App;
