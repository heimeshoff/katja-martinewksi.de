import * as react from "react";

export function footer(model, dispatch) {
    return react.createElement("div", {
        className: "w-full py-4 flex flex-col items-center justify-center",
    }, react.createElement("a", {
        className: "hover:text-blue-300",
        href: "https://www.notion.so/Impressum-1604d7b040c04f0c8083da6af93d6d54",
        target: "_blank",
    }, "Impressum"), react.createElement("div", {}, "Copyright © Heimeshoff IT"));
}

