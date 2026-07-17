// JavaScript for EditServerModal component

window.showEditModal = (modalId) => {
    let editModal = bootstrap.Modal.getOrCreateInstance((document.getElementById(`${modalId}`)), {
        backdrop: 'static', focus: true, keyboard: false
    });

    editModal.show();
};

window.hideEditModal = function (modalId) {
    const modalElement = document.getElementById(modalId);
    if (modalElement) {
        const modal = bootstrap.Modal.getInstance(modalElement);
        if (modal) {
            modal.hide();
        } else {
            // If modal instance doesn't exist, just remove the backdrop manually
            const backdrop = document.querySelector('.modal-backdrop');
            if (backdrop) {
                backdrop.remove();
            }
            document.body.classList.remove('modal-open');
        }
    }
};