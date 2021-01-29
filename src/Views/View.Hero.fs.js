import * as react from "react";

export function hero(model, dispatch) {
    return react.createElement("div", {
        className: "relative w-full h-screen flex flex-col items-center",
    }, react.createElement("img", {
        className: "w-full h-screen object-cover",
        src: "img/katja.jpg",
    }), react.createElement("div", {
        className: "absolute inset-0 flex flex-col items-center justify-end",
    }, react.createElement("div", {
        className: "glass bg-white bg-opacity-50 p-8 md:p-16 mb-8 rounded-md shadow-2xl",
    }, react.createElement("div", {
        className: "font-bold text-gray-800 text-4xl md:text-6xl lg:text-8xl",
    }, "Katja Martinewski"), react.createElement("div", {
        className: "text-xl md:text-2xl lg:text-3xl mt-6 ml-6",
    }, "Let’s create the space for your development"))));
}

