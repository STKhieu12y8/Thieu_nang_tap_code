import { SET_JOB, ADD_JOB, DELETE_JOB } from './constant'


export const initState = {
    job: '',
    jobs: []
  }
  
  const reducers = (state, action) => {
    switch (action.type) {
      case SET_JOB:
        return {
          ...state,
          job: action.payload
        }
      case ADD_JOB:
        return {
          ...state,
          jobs: [...state.jobs, action.payload]
        }
      case DELETE_JOB:
        let tempJobs = [...state.jobs]
        tempJobs.splice(action.payload, 1)
        return {
          ...state,
          jobs: tempJobs
        }
  
      default:
        throw new Error("input invalid")
    }
  
}

export default reducers