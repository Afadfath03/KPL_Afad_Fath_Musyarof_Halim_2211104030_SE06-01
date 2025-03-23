from enum import Enum

class status(Enum):
    IDLE = "Idle"
    MENUNGGU_PRODUK = "Menunggu Produk"
    MENGELUARKAN_PRODUK = "Mengeluarkan Produk"
    SELESAI = "Selesai"

class trigger(Enum):
    MASUKKAN_UANG = "Masukkan Uang"
    PILIH_PRODUK = "Pilih Produk"
    KELUARKAN_PRODUK = "Keluar Produk"
    RESET = "Reset"

State_Transition = {
    status.IDLE: {
        trigger.MASUKKAN_UANG: status.MENUNGGU_PRODUK
    },
    status.MENUNGGU_PRODUK: {
        trigger.PILIH_PRODUK: status.MENGELUARKAN_PRODUK
    },
    status.MENGELUARKAN_PRODUK: {
        trigger.KELUARKAN_PRODUK: status.SELESAI
    },
    status.SELESAI: {
        trigger.RESET: status.IDLE
    }
}

def change_state(current_state, trigger_input):
    if (current_state in State_Transition and trigger_input in State_Transition[current_state]):
        return State_Transition[current_state][trigger_input]
    return "transisi salah"

current_state = status.MENGELUARKAN_PRODUK
next_state = change_state(current_state, trigger.KELUARKAN_PRODUK)
print(next_state.value)