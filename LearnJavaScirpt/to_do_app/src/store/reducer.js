import {SET_TODO_INPUT, ADD_TODO, DELETE_TODO} from './const'

const initialState = {
    listTodo: [],
    inputTodo: ''
}

function reducer(state, action) {
    switch(action.type) {
        case SET_TODO_INPUT:
            return {
                ...state,
                inputTodo: action.payload
            }
        case ADD_TODO:
            return {
                ...state,
                listTodo: [...state.listTodo, action.payload]
            }
        case DELETE_TODO:
            let tempList = [...state.listTodo]
            tempList.splice(action.payload, 1)
                return {
                    ...state,
                    listTodo: tempList
                }
        default: 
                throw new Error('Invalid action')
    }
} 


export {initialState}
export default reducer

