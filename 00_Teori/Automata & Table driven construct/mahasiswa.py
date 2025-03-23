from enum import Enum
from gettext import translation

class student_status(Enum):
    TERDAFTAR = "Terdaftar"
    AKTIF = "Aktif"
    LULUS = "Lulus"
    CUTI = "Cuti"

class trigger_input_state(Enum):
    CETAK_KSM = "Cetak KSM"
    MENGAJUKAN_CUTI = "Mengajukan Cuti"
    MENYELESAIKAN_CUTI = "Menyelesaikan Cuti"
    LULUS = "Lulus"

state_transition = {
    student_status.TERDAFTAR: {
        trigger_input_state.CETAK_KSM: student_status.AKTIF,
        trigger_input_state.MENGAJUKAN_CUTI: student_status.CUTI
    },
    student_status.AKTIF: {
        trigger_input_state.LULUS: student_status.LULUS,
        trigger_input_state.MENGAJUKAN_CUTI: student_status.CUTI
    },
    student_status.CUTI: {
        trigger_input_state.MENYELESAIKAN_CUTI: student_status.TERDAFTAR
    }
}

def change_state(current_state, trigger_input):
    if current_state in translation and trigger_input in translation(current_state):
        translation(current_state)(trigger_input)
    return "Transisi Tidak Valid"

current_state = student_status.TERDAFTAR
