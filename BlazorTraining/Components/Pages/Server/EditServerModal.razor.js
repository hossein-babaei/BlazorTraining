// JavaScript for EditServerModal component

window.showEditModal = (modalId) => {
    let editModal = bootstrap.Modal.getOrCreateInstance((document.getElementById(`${modalId}`)), {
        backdrop: 'static', focus: true, keyboard: false
    });

    editModal.show();
};