export function focus(id) {

    const element = document.getElementById(id);

    if (!element)
        return;

    element.focus();
}