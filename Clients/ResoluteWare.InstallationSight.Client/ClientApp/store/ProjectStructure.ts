import { fetch, addTask } from 'domain-task';
import { Action, Reducer, ActionCreator } from 'redux';
import { AppThunkAction } from './';

// -----------------
// STATE - This defines the type of data maintained in the Redux store.

export interface ProjectStructureState {
    isLoading: boolean;
    projectId?: number;
    projectName?: string;
    project: Project;
}

export interface Project {
    buildingId: number;
    buildings: Building[];
}

export interface Building {
    buildingId: number;
    buildingName: string;
    floors: Floor[];
}

export interface Floor {
    floorId: number;
    floorName: string;
    rooms: Room[];
}

export interface Room {
    roomId: number;
    roomName: string;
}

interface RequestProjectStructureAction {
    type: 'REQUEST_PROJECT_STRUCTURE';
    projectId: number;
}

interface ReceiveProjectStructureAction {
    type: 'RECEIVE_PROJECT_STRUCTURE';
    projectId: number;
    project: Project;
}

// Declare a 'discriminated union' type. This guarantees that all references to 'type' properties contain one of the
// declared type strings (and not any other arbitrary string).
type KnownAction = RequestProjectStructureAction | ReceiveProjectStructureAction;

export const actionCreators = {
    requestProjectStructure: (projectId: number): AppThunkAction<KnownAction> => (dispatch, getState) => {
        // Only load data if it's something we don't already have (and are not already loading)
        if (projectId !== getState().projectStructure.projectId) {
            let fetchTask = fetch(`api/ProjectStructure/LoadProject?projectId=${projectId}`)
                .then(response => response.json() as Promise<Project>)
                .then(data => {
                    dispatch({ type: "RECEIVE_PROJECT_STRUCTURE", projectId: projectId, project: data });
                });



            addTask(fetchTask); // Ensure server-side prerendering waits for this to complete
            dispatch({ type: "REQUEST_PROJECT_STRUCTURE", projectId: projectId });
        }
    }
};

const unloadedState: ProjectStructureState = {project: Object() , projectName: "", projectId:  0, isLoading: false };

export const reducer: Reducer<ProjectStructureState> = (state: ProjectStructureState, incomingAction: Action) => {
    const action = incomingAction as KnownAction;
    switch (action.type) {
        case "REQUEST_PROJECT_STRUCTURE":
        return {
            projectId: action.projectId,
            project: state.project,
            isLoading: true
        };
        case "RECEIVE_PROJECT_STRUCTURE":
        // Only accept the incoming data if it matches the most recent request. This ensures we correctly
        // handle out-of-order responses.
            if (action.projectId === state.projectId) {
            return {
                projectId: action.projectId,
                project: action.project,
                isLoading: false
            };
        }
        break;
    default:
        // The following line guarantees that every action in the KnownAction union has been covered by a case above
        const exhaustiveCheck: never = action;
    }

    return state || unloadedState;
};