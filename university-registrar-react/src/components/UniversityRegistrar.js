import React, { useState } from 'react';
import ReusableForm from './ReusableForm';

export default function UniversityRegistrar(props) {
  const { student } = props;
  const [isEditing, setIsEditing] = useState(false);
  let button = isEditing ? null : <button onClick={() => setIsEditing(!isEditing)}>edit?</button>

  const handleEditRegistrarFormSubmission = event => {
    event.preventDefault();
    const propertiesToUpdate = {
      studentName: event.target.studentName.value,
      dateEnrolled: event.target.dateEnrolled.value,
      major: event.target.major.value,
      currentTerm: event.target.currentTerm.value,
      currentYear: event.target.currentYear.value,
    }
    props.onEditRegistrar(student.studentID, propertiesToUpdate);
    setIsEditing(!isEditing);
  }
}