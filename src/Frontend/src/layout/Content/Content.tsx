import React from "react";

const Content = ({ children }: React.ComponentProps<"main">) => {
  return <main className="m-8 md:mx-48">{children}</main>;
};

export default Content;
