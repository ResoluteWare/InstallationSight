import * as React from 'react';
import { Link, RouteComponentProps } from 'react-router-dom';
import { connect } from 'react-redux';
import { ApplicationState } from '../store';
import * as ProjectStructureState from '../store/ProjectStructure';



// At runtime, Redux will merge together...
type ProjectStructureProps =
    ProjectStructureState.ProjectStructureState        // ... state we've requested from the Redux store
    & typeof ProjectStructureState.actionCreators      // ... plus action creators we've requested
    & RouteComponentProps<{ projectId: string }>; // ... plus incoming routing parameters

class ProjectStructure extends React.Component<ProjectStructureProps, {}> {
    componentWillMount() {
        // This method runs when the component is first added to the page
        let startDateIndex = parseInt(this.props.match.params.projectId) || 0;
        this.props.requestProjectStructure(startDateIndex);
    }

    componentWillReceiveProps(nextProps: ProjectStructureProps) {
        // This method runs when incoming props (e.g., route params) change
        let startDateIndex = parseInt(nextProps.match.params.projectId) || 0;
        this.props.requestProjectStructure(startDateIndex);
    }

    public render() {
        return <div>
            <h1>Weather forecast</h1>
            <p>Test Paragraph</p>
            <p>This component demonstrates fetching data from the server and working with URL parameters.</p>
            {this.renderForecastsTable()}
            {this.renderPagination()}
        </div>;
    }

    private renderForecastsTable() {
        return <table className='table'>
            <thead>
                <tr>
                    <th>BuildingId</th>
                    <th>Building</th>
                    <th>FloorId</th>
                    <th>Floor</th>
                    <th>RoomId</th>
                    <th>Room</th>
                </tr>
            </thead>
            <tbody>
                {this.props.project.buildings.map(building =>
                    <tr key={building.buildingId}>
                        <td>{building.buildingName}</td>
                        {building.floors.map(floor =>
                            <tr key={floor.floorId}>
                                <td>{floor.floorName}</td>
                                {floor.rooms.map(room =>
                                    <tr key={room.roomId}>
                                        <td>{room.roomName}</td>
                                    </tr>
                                )}
                            </tr>
                        )}
                    </tr>
                )}
            </tbody>
        </table>;
    }

    private renderPagination() {
        let prevBuildingIdIndex = (this.props.project.buildingId || 0) - 5;
        let nextBuildingIdIndex = (this.props.project.buildingId || 0) + 5;

        return <p className='clearfix text-center'>
            <Link className='btn btn-default pull-left' to={`/fetchdata/${prevBuildingIdIndex}`}>Previous</Link>
            <Link className='btn btn-default pull-right' to={`/fetchdata/${nextBuildingIdIndex}`}>Next</Link>
            {this.props.isLoading ? <span>Loading...</span> : []}
        </p>;
    }
}

export default connect(
    (state: ApplicationState) => state.projectStructure, // Selects which state properties are merged into the component's props
    ProjectStructureState.actionCreators                 // Selects which action creators are merged into the component's props
)(ProjectStructure) as typeof ProjectStructure;
