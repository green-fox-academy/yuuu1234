from patient import Patient


class Queue:
    def __init__(self):
        self.patients = []
        self.point = 0

    def add_patient(self, patient):
        if isinstance(patient, Patient):
            self.patients.append(patient)
        else:
            print("not a valid patient")

    def remove_the_healthy_patient(self):
        self.patients = [patient for patient in self.patients if patient.severity != 0]

    def get_next_patient(self):
        next = self.patients[self.point + 1]
        if self.point < len(self.patients):
            self.point += 1
        else:
            self.point = 0
        return next
