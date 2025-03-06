from enum import Enum

class JenisKelamin(Enum):
    PRIA = 1
    WANITA = 2

Patient = []

def add_patient(nama: str, gender: JenisKelamin):
    if not isinstance(gender, JenisKelamin):
        raise ValueError("Gender harus laki-laki atau perempuan")

    Patient.append({"nama": nama, "gender": gender.name})
    print(f"Berhasil menambahkan pasien {nama} dengan gender {gender.name}")


add_patient("Aubrey", JenisKelamin.PRIA)
add_patient("Agil", JenisKelamin.PRIA)