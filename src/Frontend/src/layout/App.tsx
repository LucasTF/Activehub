import {
  QueryClient,
  QueryClientProvider,
  useQuery,
} from "@tanstack/react-query";
import { ReactQueryDevtools } from "@tanstack/react-query-devtools";
import axios from "axios";
import { Activity } from "../types/activity";
import Header from "./Header/Header";
import Content from "./Content/Content";
import Footer from "./Footer/Footer";

const queryClient = new QueryClient();

function App() {
  return (
    <QueryClientProvider client={queryClient}>
      <Activities />
      <ReactQueryDevtools initialIsOpen={false} />
    </QueryClientProvider>
  );
}

function Activities() {
  const { data } = useQuery({
    queryKey: ["activities"],
    queryFn: async () => {
      const response = await axios.get<Activity[]>(
        "http://localhost:5000/api/activities",
      );
      return response.data;
    },
  });

  return (
    <>
      <Header />
      <Content>
        <ul>
          {data?.map((activity) => {
            return <li key={activity.id}>{activity.title}</li>;
          })}
        </ul>
      </Content>
      <Footer />
    </>
  );
}

export default App;
