import React, { useState } from 'react';
import ReusableForm from './ReusableForm';

export default function Student(props) {
  const { student } = props;
  const [isEditing, setIsEditing] = useState(false);
  let button = isEditing ? null : <button onClick={() => setIsEditing(!isEditing)}>edit?</button>

  const handleEditStudentFormSubmission = event => {
    event.preventDefault();
    const propertiesToUpdate = {
      studentName: event.target.studentName.value,
      dateEnrolled: event.target.dateEnrolled.value,
      major: event.target.major.value,
      currentTerm: event.target.currentTerm.value,
      currentYear: event.target.currentYear.value,
    }
    props.onEditStudent(student.studentID, propertiesToUpdate);
    setIsEditing(!isEditing);
  }

  return (
    <React.Fragment>
      <h1>{student.studentName}</h1>
      <p>Date Enrolled: {student.dateEnrolled}</p>
      <p>Student Major: {student.major}</p>
      <p>Current Term: {student.currentTerm} Current Year: {student.currentYear}</p>
      {button}
      {isEditing ? <ReusableForm formSubmissionHandler={handleEditStudentFormSubmission}
        buttonText="save changes" /> : null}
      <br></br>
      <hr></hr>
      <button onClick={() => props.onDeleteStudent(student.studentID)}>Delete!</button>
    </React.Fragment>
  )
}