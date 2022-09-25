import { useRef, useReducer } from "react"
import { setJob, addJob, deleteJob } from './actions'
import reducers, {initState} from "./reducer"


function App() {

  const [state, dispatch] = useReducer(reducers, initState)

  const { job, jobs } = state

  const inputRef = useRef()

  const handleSubmit = () => {
    if (job.trim() === '') {
      alert("Please enter again")
      inputRef.current.focus()
    } else {
      dispatch(addJob(job))
      dispatch(setJob(''))
      inputRef.current.focus()
    }
  }

  console.log(jobs)

  return (
    <div>
      <h3>Todo</h3>
      <input
        value={job}
        placeholder="enter todo..."
        onChange={e => { dispatch(setJob(e.target.value)) }}
        ref={inputRef}
      />
      <button onClick={handleSubmit} >ADD</button>
      <ul>
        {jobs.map((job, index) => (<li key={index}>{job}
          <span style={{ marginLeft: 10, cursor: 'pointer' }} onClick={() => dispatch(deleteJob(index))} >&times;</span>
        </li>))}
      </ul>
    </div>
  )
}
export default App
